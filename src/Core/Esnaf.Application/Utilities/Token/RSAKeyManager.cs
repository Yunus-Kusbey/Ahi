using System.Security.Cryptography;

namespace Esnaf.Application.Utilities.Token
{
    public class RsaKeyManager
    {
        private readonly RSA _rsa;
        private const string KeyFilePath = "RsaToken.xml"; // Dosya yolu


        public RsaKeyManager()
        {
            using (var rsa = RSA.Create())
            {
                rsa.KeySize = 2048; // Anahtar boyutu
                var privateKey = rsa.ExportRSAPrivateKey();
                var publicKey = rsa.ExportRSAPublicKey();

                // Anahtarları dosyaya kaydedin veya başka bir yere yazın
            }
        }

        // Anahtarları XML formatında kaydet
        public void SaveKeys()
        {
            var keyXml = _rsa.ToXmlString(true); // Tüm anahtarları XML formatına çevir
            File.WriteAllText(KeyFilePath, keyXml); // Anahtarları dosyaya yaz
        }

        // Anahtarları XML formatından yükle
        public void LoadKeys()
        {
            if (File.Exists(KeyFilePath))
            {
                var keyXml = File.ReadAllText(KeyFilePath); // Anahtar dosyasını oku
                _rsa.FromXmlString(keyXml); // XML'den RSA anahtarını yükle
            }
            else
            {
                throw new FileNotFoundException($"Anahtar dosyası bulunamadı: {KeyFilePath}");
            }
        }

        public RSA GetRsa() => _rsa; // RSA nesnesini döndür
    }
}
