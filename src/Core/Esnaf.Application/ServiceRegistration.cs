using Esnaf.Domain.Entities.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
namespace Esnaf.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            collection.AddIdentity<User, Role>()
        .AddUserStore<ICustomIdentityUser>() // Kendi kullanıcı deposu
        .AddRoleStore<ICustomIdentityRole>() // Kendi rol deposu
        .AddDefaultTokenProviders();

            collection.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "MyApp",
                    ValidAudience = "MyAppUser",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("A1b2C3d4E5f6G7h8I9j0K1l2M3n4O5p6"))
                };
            });
            collection.AddAuthorization();

            collection.AddControllers();
        }


    }
}
