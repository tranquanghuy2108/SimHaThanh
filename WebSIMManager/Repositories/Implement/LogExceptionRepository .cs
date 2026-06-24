using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories.Implement
{
    public class LogExceptionRepository : ILogExceptionRepository
    {
        private readonly SIMCenterDbContext _context;
        public LogExceptionRepository(SIMCenterDbContext context)
        {
            _context = context;
        }

        public async Task<int> InsertLogException(LogException log, Guid createBy)
        {
            try
            {
                var _dataEntity = new LogException();
                _dataEntity.ControllerName = log.ControllerName;
                _dataEntity.ActionName = log.ActionName;
                _dataEntity.ExceptionName = log.ExceptionName;
                _dataEntity.CreateBy = createBy;
                _dataEntity.CreateTime = DateTime.Now;
                _dataEntity.UpdateBy = createBy;
                _dataEntity.UpdateTime = DateTime.Now;

                await _context.LogExceptions.AddAsync(_dataEntity);
                _context.SaveChanges();
                return _context.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }

}
