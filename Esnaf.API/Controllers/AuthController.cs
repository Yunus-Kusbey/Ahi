using Esnaf.Application.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Esnaf.API.Controllers
{
    public class AuthController : ControllerBase
    {

        public AuthController()
        {
        }

        [HttpPost("login")]
        public IActionResult Login(string username)
        {
            // Kullanıcının doğrulanması (örneğin, veritabanında kontrol)
            // Doğrulama başarılıysa token oluştur:
            /*string token = _tokenService.GenerateToken(username);
            return Ok(new { Token = token });*/
            return Ok();
        }

        [HttpPost("validate")]
        public IActionResult Validate(string token)
        {/*
            bool isValid = _tokenService.ValidateToken(token);
            return Ok(new { IsValid = isValid });*/
            return Ok(token);
        }
    }
}
