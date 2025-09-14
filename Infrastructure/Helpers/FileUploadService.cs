using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Infrastructure.Services
{
    public class FileUploadService
    {
        private readonly string _uploadPath;

        public FileUploadService(IConfiguration config)
        {
            _uploadPath = config["UploadPath"] ?? "Uploads/";
        }

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("Invalid file");

            var extension = Path.GetExtension(file.FileName).ToUpper();
            var allowedExt = new[] { ".DOC", ".JPG", ".GIF", ".PDF", ".TXT", ".XLS", ".ZIP", ".CSV" };

            if (!allowedExt.Contains(extension))
                throw new InvalidOperationException("Invalid file type");

            var fileName = $"{DateTime.Now:ddMMyyyyHHmmss}_{Path.GetFileName(file.FileName)}";
            var path = Path.Combine(_uploadPath, fileName);

            Directory.CreateDirectory(_uploadPath);
            using var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return fileName;
        }
    }
}
