namespace BlazorUploadFile.Api.Services
{
    public interface ILocalStorageService
    {
        Task<string> InsertFile(IFormFile file);
    }
}
