using Esnaf.Application;
using Esnaf.Infrastructure;
using Esnaf.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateAudience = true, //Oluþturulacak token deðerini kimlerin/hangi originlerin/sitelerin kullanýcý belirlediðimiz deðerdir. -> www.bilmemne.com
            ValidateIssuer = true, //Oluþturulacak token deðerini kimin daðýttýný ifade edeceðimiz alandýr. -> www.myapi.com
            ValidateLifetime = true, //Oluþturulan token deðerinin süresini kontrol edecek olan doðrulamadýr.
            ValidateIssuerSigningKey = true, //Üretilecek token deðerinin uygulamamýza ait bir deðer olduðunu ifade eden suciry key verisinin doðrulanmasýdýr.

            ValidAudience = builder.Configuration["Token:Audience"],
            ValidIssuer = builder.Configuration["Token:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
            LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,
            NameClaimType = ClaimTypes.Name, //JWT üzerinde Name claimne karþýlýk gelen deðeri User.Identity.Name propertysinden elde edebiliriz.
            RoleClaimType = ClaimTypes.Role // Rol doðrulamasý için kullanýlýyor
        };
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowCors",
        builder => builder.WithOrigins("https://localhost:7278/api/")
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});
builder.Services.AddControllers();

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();

builder.Services.AddSwaggerGen();





var app = builder.Build();

// HTTP isteði boru hattýný yapýlandýr
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // HTTPS yönlendirmesi
app.UseRouting(); // Yönlendirme middleware'i
app.UseCors("AllowCors");
app.UseAuthentication(); // Kimlik doðrulama middleware'i
app.UseAuthorization(); // Yetkilendirme middleware'i
app.MapControllers();
// Controller'larý eþleþtir
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
