using AdminPanelService.Models;
using AdminPanelService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Controllers
{
    [Route("[controller]")]
    [Controller]
    public class ImageController : Controller
    {
        private readonly ImageService _data;
        public ImageController(ImageService data)
        {
            _data = data;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadImage()
        {
            var file = Request.Form.Files[0];

            if(file.Length > 0)
            {
                return Ok(await _data.SaveImageAsync(file));
            }

            return BadRequest(); 
        }
    }
}
