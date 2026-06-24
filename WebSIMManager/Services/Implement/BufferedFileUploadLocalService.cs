using Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Services
{
    public class BufferedFileUploadLocalService : IBufferedFileUploadService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public BufferedFileUploadLocalService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<string> UploadFile(IFormFile file)
        {
            string path = String.Empty;
            try
            {
                if (file.Length > 0)
                {
                    string uploadPath = Path.GetFullPath(Path.Combine(_hostingEnvironment.WebRootPath, "GameImgs"));
                    path = "GameImgs\\" + file.FileName;
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }
                    if (File.Exists(path))
                    {
                        Guid guid = Guid.NewGuid();
                        path = "GameImgs\\" + guid.ToString() + file.FileName;
                    }
                    using (var fileStream = new FileStream(Path.Combine(uploadPath, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    path = "GameImgs\\" + file.FileName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
                path = String.Empty;
            }
            return path;
        }
        public bool RemoveUploadFile(string fileUrl)
        {
            try
            {
                string path = Path.GetFullPath(Path.Combine(_hostingEnvironment.WebRootPath)) + "\\" + fileUrl;
                if (Path.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}