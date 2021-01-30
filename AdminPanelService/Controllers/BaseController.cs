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
    public class BaseController<T> : Controller
    {
        protected readonly T _data; 

        public BaseController(T Data)
        {
            _data = Data;
        }
    }
}
