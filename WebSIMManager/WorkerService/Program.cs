using EFCoreMySQL.DataContext;
using Microsoft.EntityFrameworkCore;
using WorkerService;
using WorkerService.Services;

//
//var connectionStr = "Server=localhost; User ID=root; Password=Abcd@12346; Database=HTSIMCenter";
//var connectionStr = "Server=42.96.60.94; User ID=remote; Password=Abcd@12345; Database=HTSIMCenter_dev";
var connectionStr = "Server=localhost; User ID=root; Password=Abcd@12345; Database=HTSIMCenter";
var optionsBuilder = new DbContextOptionsBuilder<SIMCenterDbContext>();
optionsBuilder.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr));

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService()
    .ConfigureServices(services =>
    {
        services.AddScoped<SIMCenterDbContext>(db => new SIMCenterDbContext(optionsBuilder.Options));
        services.AddHostedService<VNPTSimHandle>();
    })
    .Build();

host.Run();