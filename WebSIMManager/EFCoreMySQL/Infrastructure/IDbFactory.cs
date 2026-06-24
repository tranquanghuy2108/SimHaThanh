using EFCoreMySQL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMySQL.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SIMCenterDbContext Init();
    }
}
