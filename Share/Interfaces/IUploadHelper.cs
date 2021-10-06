using Microsoft.AspNetCore.Http;

namespace Share.Interfaces
{
    public interface IUploadHelper
    {
        void UploadImage(IFormFile file, string rootPath, string phanloai);
        void RemoveImage(string filePath);
    }
}
