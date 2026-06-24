using Commons.Sessions;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.EntityFrameworkCore;
using Models.Requests;
using Models.Responses;
using Models.ViewModels;
using MySqlConnector;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Repositories.Implement
{
    public class LogActionRepository : ILogActionRepository
    {
        private readonly SIMCenterDbContext _context;
        public LogActionRepository(SIMCenterDbContext context)
        {
            _context = context;
        }
        public ResponseDataViewModel<LogSYSViewModel> GetLogSys(LogSYSRequestModel request)
        {
            try
            {
                List<LogSYSViewModel> data = new();

                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetLogSYS";
                string query = $"CALL {storedProcedureName}(@IsPaged, @PageIndex, @PageSize, @Keyword, @StartDate, @EndDate)";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                {
                    new("@IsPaged", request.isPaged ? 1 : 0),
                    new("@PageIndex", request.pageIndex),
                    new("@PageSize", request.pageSize),
                    new("@Keyword", request.keyword),
                    new("@StartDate", request.startDate),
                    new("@EndDate", request.endDate)
                };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = _context.Set<LogSYSViewModel>().FromSqlRaw(query, parameters.ToArray()).ToList();

                // Thêm dữ liệu vào danh sách data
                data.AddRange(dataExec);

                // Tạo đối tượng Pager và ResponseDataViewModel
                var pager = new Pager(new PagingRequestBase() { pageIndex = request.pageIndex, pageSize = request.pageSize }, data?.FirstOrDefault()?.TotalCount ?? 0);
                var responseData = new ResponseDataViewModel<LogSYSViewModel>() { Pager = pager, Data = data };

                return responseData;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi và trả về ResponseDataViewModel rỗng
                Console.WriteLine("Error: " + ex);
                return new ResponseDataViewModel<LogSYSViewModel>();
            }
        }
        public int InsertLogAction(LogAction logAction)
        {
            try
            {
                var _dataEntity = new LogAction();
                _dataEntity.IpAddressUser = SessionsData.IPAddress;
                _dataEntity.ControllerName = logAction.ControllerName;
                _dataEntity.ActionName = logAction.ActionName;
                _dataEntity.OldData = logAction.OldData;
                _dataEntity.NewData = logAction.NewData;
                _dataEntity.CreateBy = logAction.CreateBy;
                _dataEntity.CreateTime = DateTime.Now;
                _dataEntity.UpdateBy = logAction.CreateBy;
                _dataEntity.UpdateTime = DateTime.Now;

                _context.LogActions.Add(_dataEntity);
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
