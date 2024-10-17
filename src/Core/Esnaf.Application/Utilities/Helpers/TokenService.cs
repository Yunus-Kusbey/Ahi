using Esnaf.Application.Abstractions.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Utilities.Helpers
{
    public class TokenService
    {


        private readonly RSA _rsa;

        public TokenService(RSA rsa)
        {
            _rsa = rsa;
        }

        public string GenerateToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var signingCredentials = new SigningCredentials(new RsaSecurityKey(_rsa), SecurityAlgorithms.RsaSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim(ClaimTypes.Name, username)
        }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = signingCredentials
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token); // Token'ı döndür
        }


        public bool ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            if (string.IsNullOrWhiteSpace(token))
            {
                return false; // Token boşsa
            }

            try
            {
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new RsaSecurityKey(_rsa),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };

                tokenHandler.ValidateToken(token, validationParameters, out _);
                return true;
            }
            catch (Exception ex)
            {
                // Hata mesajını inceleyin
                Console.WriteLine($"Token validation error: {ex.Message}");
                return false; // Doğrulama başarısız
            }
        }
    }
}

