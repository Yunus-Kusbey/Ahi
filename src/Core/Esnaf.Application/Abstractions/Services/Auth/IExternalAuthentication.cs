﻿using Esnaf.Application.DTOs;
using Esnaf.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Application.Abstractions.Services.Auth
{
    public interface IExternalAuthentication
    {
        public Task<TokenDTO> GoogleLoginAsynch(string idToken, int accessTokenLifeTime);
    }
}