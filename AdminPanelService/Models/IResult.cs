using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Models
{
    public interface IResult
    {
        object Data { get; set; }

        HttpStatusCode StatusCode { get; set; }

        string ErrorMessage { get; set; }

        string SuccessMessage { get; set; }
    }
}
