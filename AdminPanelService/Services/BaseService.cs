using AdminPanelService.Data;
using AdminPanelService.Models;
using System.Net;
using System.Threading.Tasks;
using AdminPanelService.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelService.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseModel{

        protected readonly Repasitory<T> _repository;

        protected readonly string _nameObject = typeof(T).Name;

        public BaseService(Repasitory<T> repository)
        {
            _repository = repository;
        }

        public abstract  Task<IResult> Delete(int id);

        public abstract Task<IResult> GetById(int id);

        public abstract Task<IResult> GetList();

        public abstract Task<IResult> Set(T obj);

        public abstract Task<IResult> Update(int id, T obj);

        protected IResult ErrorResult(HttpStatusCode code, EMessages message, string nameObject)
        {
            return new Result
            {
                ErrorMessage = string.Format(StringEnum.GetStringValue(message), nameObject),
                StatusCode = code
            };
        }

        protected IResult OkResult(HttpStatusCode code, EMessages message, string nameObject, object data = null)
        {
            return new Result
            {
                Data = data,
                SuccessMessage = string.Format(StringEnum.GetStringValue(message), nameObject),
                StatusCode = code
            };
        }
    }
}
