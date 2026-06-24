using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace Services
{
    public class StreamFileUploadLocalService : IStreamFileUploadService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public StreamFileUploadLocalService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<List<string>> UploadFile(MultipartReader reader, MultipartSection? section)
        {
            List<string> filePaths = new();
            while (section != null)
            {
                var hasContentDispositionHeader = ContentDispositionHeaderValue.TryParse(
                 section.ContentDisposition, out var contentDisposition
                );

                if (hasContentDispositionHeader)
                {
                    if (contentDisposition.DispositionType.Equals("form-data") &&
                    (!string.IsNullOrEmpty(contentDisposition.FileName.Value) ||
                    !string.IsNullOrEmpty(contentDisposition.FileNameStar.Value)))
                    {
                        var filePath = Path.GetFullPath(Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFolder"));
                        byte[] fileArray;
                        using (var memoryStream = new MemoryStream())
                        {
                            await section.Body.CopyToAsync(memoryStream);
                            fileArray = memoryStream.ToArray();
                        }
                        using (var fileStream = File.Create(Path.Combine(filePath, contentDisposition.FileName.Value)))
                        {
                            await fileStream.WriteAsync(fileArray);
                        }
                        filePaths.Add(filePath);
                    }
                }
                section = await reader.ReadNextSectionAsync();
            }
            return filePaths;
        }
    }
}