using AdminPanelService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                //TODO
            }
            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetTest()
        {
            return Ok(new User { Id = 1, Email = "my@gmail.com", Password = "123" });
        }
    }
}
