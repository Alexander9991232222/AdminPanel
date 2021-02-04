using AdminPanelService.Data;
using AdminPanelService.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace AdminPanelService.Services
{
    public class ImageService
    {
        protected IResultBuilder _resultBuilder;

        public ImageService(IResultBuilder resultBuilder)
        {
            _resultBuilder = resultBuilder;
        }

        public async Task<IResult> SaveImageAsync (IFormFile file)
        {
            try
            {
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                var fileName = file.FileName.Trim();
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);

                using(var stream = new FileStream(fullPath, FileMode.Create))
                await file.CopyToAsync(stream);

                return _resultBuilder.OkResult(EMessages.FileCreated, file.FileName, dbPath);
            }
            catch
            {
                return _resultBuilder.ErrorResult(EMessages.FileIsNotCreated, file.FileName);
            }
        }

    }
}
