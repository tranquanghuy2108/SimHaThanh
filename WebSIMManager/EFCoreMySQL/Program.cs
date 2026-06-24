// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.Infrastructure;

Console.WriteLine("Hello, World!");
public class DataContextFactory : IDesignTimeDbContextFactory<SIMCenterDbContext>
{
    //static readonly string connectionString = "Server=localhost; User ID=root; Password=Abcd@12345; Database=HTSIMCenter";

    public SIMCenterDbContext CreateDbContext(string[] args)
    {
        //var optionBuilder = new DbContextOptionsBuilder<SIMCenterDbContext>();
        //optionBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        //return new SIMCenterDbContext(optionBuilder.Options);
        DbFactory dbFactory = new DbFactory();
        return dbFactory.Init();
    }
}