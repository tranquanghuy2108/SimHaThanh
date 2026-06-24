using EFCoreMySQL.EntityModels;
using Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Repositories.Implement;
using Repositories.Interface;
using Services;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using EFCoreMySQL.DataContext;
using Microsoft.EntityFrameworkCore;
using WebApplicationAPI;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

//Config for data connection
services.AddDbContext<SIMCenterDbContext>(option => 
    option.UseMySql(builder.Configuration["Settings:ConnectionStr"], 
    ServerVersion.AutoDetect(builder.Configuration["Settings:ConnectionStr"])));

services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Settings:Issuer"],
        ValidAudience = builder.Configuration["Settings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes(builder.Configuration["Settings:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true
    };
}).AddIdentityCookies(o => { }); ;
services.AddAuthorization();

var identityService = services.AddIdentityCore<AppUser>(o =>
    {
        o.SignIn.RequireConfirmedAccount = true;
    })
    .AddEntityFrameworkStores<SIMCenterDbContext>()
    .AddDefaultTokenProviders();

identityService.AddSignInManager();
//DI for Login
identityService.Services.TryAddTransient<UserManager<AppUser>, UserManager<AppUser>>();
identityService.Services.TryAddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
identityService.Services.TryAddTransient<IAccountRepository, AccountRepository>();
identityService.Services.TryAddTransient<IRoleRepository, RoleRepository>();

//DI for controler
services.AddTransient<IBufferedFileUploadService, BufferedFileUploadLocalService>();
services.AddTransient<IStreamFileUploadService, StreamFileUploadLocalService>();
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//Add Posts
services.AddTransient<IPostRepository, PostRepository>();

//Add log
services.AddTransient<ILogExceptionRepository, LogExceptionRepository>();
services.AddTransient<ILogActionRepository, LogActionRepository>();
//Add SIM, News
services.AddTransient<ISIMRepository, SIMRepository>();
services.AddTransient<ISIMOrderRepository, SIMOrderRepository>();
services.AddTransient<IContactRepository, ContactRepository>();
services.AddTransient<ICollaboratorsGroupRepository, CollaboratorsGroupRepository>();
//Other
services.AddTransient<IDebtRepository, DebtRepository>();
services.AddTransient<IBankRepository, BankRepository>();
services.AddTransient<IShippingUnitRepository, ShippingUnitRepository>();
services.AddTransient<IGoodsDeliveryNoteOfSimRepository, GoodsDeliveryNoteOfSimRepository>();
services.AddTransient<IWarehouseRepository, WarehouseRepository>();
services.AddTransient<ISystemConfigRepository, SystemConfigRepository>();
services.AddTransient<IAuctionRepository, AuctionRepository>();
services.AddTransient<INotificationRepository, NotificationRepository>();
services.AddTransient<IAppContentRepository, AppContentRepository>();
services.AddTransient<ICashBookRepository, CashBookRepository>();

builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
        policy =>
        {
            policy.WithOrigins("http://example.com",
                    "http://localhost:5205",
                    "http://8.219.203.220:81")
                .WithMethods("PUT", "DELETE", "GET", "POST");
        });
});  

var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/security/getMessage", () => "Hello World!").RequireAuthorization();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
app.Run();