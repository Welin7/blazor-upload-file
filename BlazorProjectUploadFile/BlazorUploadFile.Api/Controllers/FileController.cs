using BlazorUploadFile.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorUploadFile.Api.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FileController : ControllerBase
    {
        private readonly ILocalStorageService _localStorageService;
        
        public FileController(ILocalStorageService localStorageService) 
        {
            this._localStorageService = localStorageService;
        }

        [HttpPost]

        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            var fileSavedPath = await _localStorageService.InsertFile(file);
            return fileSavedPath;
        }
    }
}