using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.ViewModels;
using MediatR;

namespace Esnaf.Application.Features.Commands.AppUser.OTPSend
{
    internal class OTPSendCommandHandler : IRequestHandler<OTPSendCommandRequest, Token?>
    {
        private readonly IRedisCacheService _redis;
        private readonly IAuthService _authService;
        public OTPSendCommandHandler(IRedisCacheService redis,IAuthService authService)
        {
            _redis = redis;
            _authService = authService;
        }
        public async Task<Token?> Handle(OTPSendCommandRequest request, CancellationToken cancellationToken)
        {
            var a = await _authService.PhoneLoginAsync(request.Phone.ToString());
            if (a!=null)
            {
                Random rnd = new Random();
                Int32 sayi = rnd.Next(100000, 999999);
                if (await _redis.SetCacheValueAsync(request.Phone.ToString(), sayi, 5) == false)
                {
                    return null;
                }
                if(await _authService.SendOTPAsync(request.Phone.ToString(), sayi))
                {
                    return a;
                }                    
            }
            return null;
        }
    }
}
