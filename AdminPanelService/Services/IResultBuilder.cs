using AdminPanelService.Data;
using AdminPanelService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Services
{
    public interface IResultBuilder
    {
         IResult ErrorResult(EMessages message, string nameObject);

        IResult OkResult(EMessages message, string nameObject, object data = null);

        IResult NotFoundResult(EMessages message, string nameObject);

        IResult InternalServerError(EMessages message, string nameObject);
    }
}
