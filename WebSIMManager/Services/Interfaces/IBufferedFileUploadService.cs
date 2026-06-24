using Microsoft.AspNetCore.Http;

namespace Interfaces
{
    public interface IBufferedFileUploadService
    {
        Task<string> UploadFile(IFormFile file);
        bool RemoveUploadFile(string fileName);
    }
}
