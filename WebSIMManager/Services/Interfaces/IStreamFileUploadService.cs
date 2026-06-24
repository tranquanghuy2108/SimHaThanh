using Microsoft.AspNetCore.WebUtilities;

namespace Interfaces
{
    public interface IStreamFileUploadService
    {
        Task<List<string>> UploadFile(MultipartReader reader, MultipartSection section);
    }
}
