using Esnaf.Persistence;
using Esnaf.Application;
using Ocelot.DependencyInjection;
using Esnaf.Application.Utilities.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddOcelot();


var rsaKeyManager = new RsaKeyManager();
rsaKeyManager.SaveKeys(); // Anahtarlarý kaydet
rsaKeyManager.LoadKeys(); // Anahtarlarý yükle
builder.Services.AddSingleton(rsaKeyManager);
builder.Services.AddSingleton<RSA>(rsaKeyManager.GetRsa());

// JWT ayarlarýný yapýlandýr
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new RsaSecurityKey(rsaKeyManager.GetRsa()),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();


builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.WithOrigins("http://localhost:5101", "https://localhost:5101").AllowAnyHeader().AllowAnyMethod().AllowCredentials()
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
