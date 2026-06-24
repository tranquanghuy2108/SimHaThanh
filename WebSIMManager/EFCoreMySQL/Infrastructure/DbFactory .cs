using EFCoreMySQL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SIMCenterDbContext dbContext;
        //product
        static readonly string connectionString = "Server=localhost; User ID=root; Password=Abcd@12345; Database=HTSIMCenter";
        //Dev
        //static readonly string connectionString = "Server=localhost; User ID=root; Password=Abcd@12345; Database=HTSIMCenter_dev";
        //Remote dev
        //static readonly string connectionString = "Server=42.96.60.94; User ID=remote; Password=Abcd@12345; Database=HTSIMCenter_dev";

        public SIMCenterDbContext Init()
        {
            var optionBuilder = new DbContextOptionsBuilder<SIMCenterDbContext>();
            optionBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return dbContext ?? (dbContext = new SIMCenterDbContext(optionBuilder.Options));
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
