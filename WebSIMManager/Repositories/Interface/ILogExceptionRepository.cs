using EFCoreMySQL.EntityModels;

namespace Repositories.Interface
{
    public interface ILogExceptionRepository
    {
        Task<int> InsertLogException(LogException log, Guid createBy);
    }
}
