using AdminPanelService.Data;
using AdminPanelService.Helpers;
using AdminPanelService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Services
{
    public class ResultBuilderService : IResultBuilder
    {
        public IResult ErrorResult(EMessages message, string nameObject)
        {
            return new Result
            {
                ErrorMessage = string.Format(StringEnum.GetStringValue(message), nameObject),
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }

        public IResult InternalServerError(EMessages message, string nameObject)
        {
            return new Result
            {
                ErrorMessage = string.Format(StringEnum.GetStringValue(message), nameObject),
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }

        public IResult NotFoundResult(EMessages message, string nameObject)
        {
            return new Result
            {
                ErrorMessage = string.Format(StringEnum.GetStringValue(message), nameObject),
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }

        public IResult OkResult(EMessages message, string nameObject, object data = null)
        {
            return new Result
            {
                SuccessMessage = string.Format(StringEnum.GetStringValue(message), nameObject),
                StatusCode = System.Net.HttpStatusCode.OK,
                Data = data
            };
        }
    }
}
