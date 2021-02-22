using AdminPanelService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdminPanelService.Controllers
{
    public class ProductController : BaseController<ProductService>
    {
        public ProductController(ProductService data) : base(data)
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _data.GetList());
        }
    }
}
