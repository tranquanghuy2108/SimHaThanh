using EFCoreMySQL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.EventLog;
using WS_UpdateSimVNPT;

//
//var connectionStr = "Server=localhost; User ID=root; Password=Abcd@12345; Database=HTSIMCenter_dev";
//var connectionStr = "Server=42.96.60.94; User ID=remote; Password=Abcd@12345; Database=HTSIMCenter_dev";
var connectionStr = "Server=localhost; User ID=root; Password=Abcd@12345; Database=HTSIMCenter";
var optionsBuilder = new DbContextOptionsBuilder<SIMCenterDbContext>();
optionsBuilder.UseMySql(connectionStr, ServerVersion.AutoDetect(connectionStr));

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService()
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders();
        logging.AddConsole();
        logging.AddFile("logs/app.txt");
    })
    .ConfigureServices(services =>
    {
        services.AddScoped<SIMCenterDbContext>(db => new SIMCenterDbContext(
            optionsBuilder.Options
        ));
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
