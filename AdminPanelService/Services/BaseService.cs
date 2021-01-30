using AdminPanelService.Data;
using AdminPanelService.Models;
using System.Net;
using System.Threading.Tasks;
using AdminPanelService.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelService.Services
{
    public abstract class BaseService<T> where T : IBaseModel, IBaseService<T> 
    {
        protected readonly AppDbContext _context;

        protected readonly string _nameObject = typeof(T).Name;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public abstract  Task<IResult> Delete(long id);

        public abstract Task<IResult> GetById(long id);

        public abstract Task<IResult> GetList();

        public abstract Task<IResult> Set(T obj);

        public abstract Task<IResult> Update(long id, T obj);

        protected IResult ErrorResult(HttpStatusCode code, EMessages messages, string nameObject)
        {
            return new Result
            {
                ErrorMessage = string.Format(StringEnum.GetStringValue(messages), nameObject),
                StatusCode = code
            };
        }

        protected IResult OkResult(HttpStatusCode code, EMessages messages, string nameObject, object data = null)
        {
            return new Result
            {
                Data = data,
                SuccessMessage = string.Format(StringEnum.GetStringValue(messages), nameObject),
                StatusCode = code
            };
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public T FindById(long id)
        {
            var t = _context.GetType();
            var db = t
                .GetProperty(typeof(T).Name)
                .GetValue(_context);

            if(db is DbContext context)
            {
                return context.ToL
            } 
        }
    }
}
