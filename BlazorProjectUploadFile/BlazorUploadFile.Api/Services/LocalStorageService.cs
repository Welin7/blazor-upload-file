namespace BlazorUploadFile.Api.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        public async Task<string> InsertFile(IFormFile file)
        {
            var tempPath = Path.GetTempPath();

            var filePath = Path.Combine(tempPath, file.FileName);

            using(var fileStream = System.IO.File.Create(filePath))
            {
                await file.CopyToAsync(fileStream);
            }

            return filePath;
        }
    }
}
