using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using VetClinic_Server.Service.IService;

namespace VetClinic_Server.Service
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<FileUpload> _logger;

        public FileUpload(IWebHostEnvironment webHostEnvironment, ILogger<FileUpload> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                var fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid() + fileInfo.Extension;
                var folderDirectory = $"{_webHostEnvironment.WebRootPath}\\AnimalImages";
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "AnimalImages", fileName);

                var memoryStream = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStream);

                if (!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }

                await using var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                memoryStream.WriteTo(fs);
                var fullPath = $"AnimalImages/{fileName}";
                return fullPath;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        public bool DeleteFile(string fileName)
        {
            try
            {
                var path = $"{_webHostEnvironment.WebRootPath}\\AnimalImages\\{fileName}";

                if (!File.Exists(path)) return false;

                File.Delete(path);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
