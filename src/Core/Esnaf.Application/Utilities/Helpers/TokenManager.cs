using System.Security.Claims;
using System.Security.Cryptography;
using Jose; // JWT library
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl; // For PEM reading
using Org.BouncyCastle.Security; // For converting keys

namespace Esnaf.Application.Utilities.Helpers
{
    public static class TokenManager
    {
        private static readonly string _privateKeyFileName = GetKeyPath("privateKey.pem");
        private static readonly string _publicKeyFileName = GetKeyPath("publicKey.pem");

        static TokenManager()
        {
            // Anahtar dosyalarının varlığını kontrol et
            if (!File.Exists(_privateKeyFileName) || !File.Exists(_publicKeyFileName))
            {
                SaveKey();
            }
        }
        private static string GetKeyPath(string fileName)
        {
            // Anahtar dosyalarını uygulamanın çalışma dizinine göre otomatik olarak belirliyoruz
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(basePath, "keys", fileName); // keys klasörü altına koyacağız
        }
        private static void SaveKey()
        {
            var keyGen = new RsaKeyPairGenerator();
            keyGen.Init(new KeyGenerationParameters(new SecureRandom(), 2048));

            // Anahtar çiftini oluştur
            AsymmetricCipherKeyPair keyPair = keyGen.GenerateKeyPair();

            // Özel anahtarı kaydet
            using (var writer = new StreamWriter(_privateKeyFileName))
            {
                var pemWriter = new PemWriter(writer);
                pemWriter.WriteObject(keyPair.Private);
                writer.Flush();
            }

            // Açık anahtarı kaydet
            using (var writer = new StreamWriter(_publicKeyFileName))
            {
                var pemWriter = new PemWriter(writer);
                pemWriter.WriteObject(keyPair.Public);
                writer.Flush();
            }
        }
        public static string CreateToken(List<Claim> claims)
        {
            RSAParameters rsaParams;

            // PEM formatındaki RSA özel anahtarını okuma
            using (var tr = new StringReader(File.ReadAllText(_privateKeyFileName)))
            {
                var pemReader = new PemReader(tr);
                var keyPair = pemReader.ReadObject() as AsymmetricCipherKeyPair;

                if (keyPair == null)
                {
                    throw new Exception("Could not read RSA private key");
                }

                var privateRsaParams = keyPair.Private as RsaPrivateCrtKeyParameters;
                rsaParams = DotNetUtilities.ToRSAParameters(privateRsaParams);
            }

            // RSA anahtarını içe aktarma ve JWT oluşturma
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(rsaParams);

                // Claims'den payload oluşturma
                var payload = claims.ToDictionary(k => k.Type, v => (object)v.Value);

                // JWT encode (imzalama)
                return Jose.JWT.Encode(payload, rsa, JwsAlgorithm.RS256);
            }
        }

        public static string DecodeToken(string token)
        {
            RSAParameters rsaParams;

            // PEM formatındaki RSA açık anahtarını okuma
            using (var tr = new StringReader(File.ReadAllText(_publicKeyFileName)))
            {
                var pemReader = new PemReader(tr);
                var publicKeyParams = pemReader.ReadObject() as RsaKeyParameters;

                if (publicKeyParams == null)
                {
                    throw new Exception("Could not read RSA public key");
                }

                rsaParams = DotNetUtilities.ToRSAParameters(publicKeyParams);
            }

            // RSA açık anahtarı ile token doğrulama
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(rsaParams);

                // JWT çözümleme (imza doğrulaması yapar, hata verirse imza geçersizdir)
                return Jose.JWT.Decode(token, rsa, JwsAlgorithm.RS256);
            }
        }
    }
}
