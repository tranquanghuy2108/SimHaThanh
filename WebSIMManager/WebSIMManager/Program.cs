using System.Globalization;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Repositories.Implement;
using Repositories.Interface;
using Services;

// Ngăn BrowserLink tự inject
Environment.SetEnvironmentVariable("DOTNET_USE_POLLING_FILE_WATCHER", "1");
Environment.SetEnvironmentVariable("ASPNETCORE_HOSTINGSTARTUPASSEMBLIES", "");

// Cấu hình ngôn ngữ mặc định (vi-VN hoặc en-US tuỳ bạn muốn)
var defaultCulture = new CultureInfo("en-US"); // hoặc "en-US"
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = new List<CultureInfo> { defaultCulture },
    SupportedUICultures = new List<CultureInfo> { defaultCulture },
};
var builder = WebApplication.CreateBuilder(args);

// Handle Configuration
var settings = builder.Configuration.GetSection("Settings").Get<Models.Config.Settings>();

builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = null; // Bỏ giới hạn kích thước body request
});

// Add services to the container.
var services = builder.Services;

// Tăng kích thước giới hạn request
services.Configure<FormOptions>(options =>
{
    options.ValueCountLimit = int.MaxValue; // Đặt giới hạn số lượng value tối đa
    options.ValueLengthLimit = int.MaxValue; // Đặt giới hạn độ dài của từng value tối đa
    options.KeyLengthLimit = int.MaxValue; // Đặt giới hạn độ dài của từng key tối đa
    options.MultipartBodyLengthLimit = long.MaxValue; // Đặt giới hạn kích thước của multipart body tối đa
});
services.AddControllersWithViews(options =>
{
    options.MaxModelBindingCollectionSize = int.MaxValue; // Tăng giới hạn model request
});

//Add config for Session
services.AddDistributedMemoryCache();
services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(2);
    options.Cookie.IsEssential = true;
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});

//Config for data connection
services.AddDbContext<SIMCenterDbContext>(option =>
    option.UseMySql(settings.ConnectionStr, ServerVersion.AutoDetect(settings.ConnectionStr))
);

//Config when login
services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/login";
        option.LogoutPath = "/logout";
        option.Cookie.SameSite = SameSiteMode.None;
        option.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        option.Cookie.IsEssential = true;
        option.SlidingExpiration = true;
    });

services
    .AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<SIMCenterDbContext>()
    .AddDefaultTokenProviders();

services.Configure<IdentityOptions>(options =>
{
    // Default Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(365 * 100);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
});

//
services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
});

//DI for controler
services.AddTransient<IBufferedFileUploadService, BufferedFileUploadLocalService>();
services.AddTransient<IStreamFileUploadService, StreamFileUploadLocalService>();
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//DI for Login
services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
services.AddTransient<IAccountRepository, AccountRepository>();
services.AddTransient<IRoleRepository, RoleRepository>();

//Add log
services.AddTransient<ILogExceptionRepository, LogExceptionRepository>();
services.AddTransient<ILogActionRepository, LogActionRepository>();

//Add SIM, News
services.AddTransient<ISIMRepository, SIMRepository>();
services.AddTransient<ISIMOrderRepository, SIMOrderRepository>();
services.AddTransient<IContactRepository, ContactRepository>();
services.AddTransient<ICollaboratorsGroupRepository, CollaboratorsGroupRepository>();
services.AddTransient<INewsRepository, NewsRepository>();

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

services.AddControllersWithViews();
services.AddRazorPages();

//services.AddMvc(options =>
//    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute())).AddRazorOptions();
//Get Ip
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
services
    .AddMvc()
    .AddRazorPagesOptions(options =>
    {
        options.Conventions.AddPageRoute("/login", "");
    });
services.ConfigureApplicationCookie(o =>
{
    o.ExpireTimeSpan = TimeSpan.FromDays(1);
    o.SlidingExpiration = true;
});
services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
    );
});

// Handle Application of Game
var app = builder.Build();

// Đặt middleware localization
app.UseRequestLocalization(localizationOptions);

app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    var context = serviceScope.ServiceProvider.GetService<SIMCenterDbContext>();
    context.Database.Migrate();
}

app.UseHttpsRedirection();

// Before any other output generating middleware handlers

app.UseForwardedHeaders(
    new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto,
    }
);

app.UseStaticFiles();

app.UseSession();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Acc}/{action=Index}/{id?}");
app.UseStatusCodePages(async context =>
{
    context.HttpContext.Response.Redirect("/forbidden");
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapGet(
        "/",
        async context =>
        {
            context.Response.Redirect("/login");
        }
    );
});
app.MapRazorPages();

app.MapControllers(); // Sử dụng Controller

app.Run();
