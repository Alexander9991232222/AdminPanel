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
    public class AvatarController : Controller
    {
        public AvatarController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetImage()
        {
            return Ok("Hello I'am a iamage conteroller");
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];

                if(file.Length > 0)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
