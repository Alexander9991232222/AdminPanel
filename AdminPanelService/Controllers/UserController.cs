using AdminPanelService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdminPanelService.Controllers
{
    public class UserController : BaseController<UserService>
    {

        public UserController(UserService data) : base(data)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetUserListAsync()
        {
            return Ok( await _data.GetList());
        }
    }
}
