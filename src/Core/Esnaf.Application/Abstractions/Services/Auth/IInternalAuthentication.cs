using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services.Auth
{
    public interface IInternalAuthentication
    {
        public Task<ViewModels.Token> PhoneLoginAsync(UserLoginDTO userLogin,int accesLifeTime);
        public Task<ViewModels.Token> RefreshTokenLoginAsync(UserLoginDTO userLogin);
    }
}
