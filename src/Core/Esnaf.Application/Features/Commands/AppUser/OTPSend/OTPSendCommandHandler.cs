using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.Exceptions;
using MediatR;

namespace Esnaf.Application.Features.Commands.AppUser.OTPSend
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
                Int32 sayi = rnd.Next(100000, 999999);
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
