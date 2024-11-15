using Ahi.FileService.source.Domain.Interfaces;
using Ahi.UserService.source.Application.DTOs.Auth;
using Ahi.UserService.source.Application.Exceptions;
using Ahi.UserService.source.Domain.Interfaces.Services;
using MediatR;

namespace Ahi.UserService.source.Application.Features.Commands.OTPSend
{
    internal class OTPSendCommandHandler : IRequestHandler<OTPSendCommandRequest, UserAccessedLoginDTO?>
    {
        private readonly IRedisCacheService _redis;
        private readonly IAuthService _authService;
        public OTPSendCommandHandler(IRedisCacheService redis, IAuthService authService)
        {
            _redis = redis;
            _authService = authService;
        }
        public async Task<UserAccessedLoginDTO?> Handle(OTPSendCommandRequest request, CancellationToken cancellationToken)
        {
            var a = await _authService.PhoneLoginAsync(request.Phone);
            if (a.Id != Guid.Empty)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(100000, 999999);
                if (!await _redis.GetAsync(request.Phone))
                {
                    if (await _redis.SetCacheValueAsync(request.Phone, sayi, 5))
                    {
                        if (await _authService.SendOTPAsync(request.Phone, sayi))
                        {
                            return a;
                        }
                        throw new NotFoundUserException();
                    }
                }
            }
            return null;
        }
    }
}
