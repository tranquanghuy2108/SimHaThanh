using EFCoreMySQL.EntityModels;
using Models.Responses;
using Models.ViewModels;

namespace Repositories.Interface
{
    public interface ILogActionRepository
    {
        ResponseDataViewModel<LogSYSViewModel> GetLogSys(LogSYSRequestModel request);
        int InsertLogAction(LogAction logAction);
    }
}
