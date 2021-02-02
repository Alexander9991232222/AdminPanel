using AdminPanelService.Data;
using AdminPanelService.Models;
using System.Net;
using System.Threading.Tasks;
using AdminPanelService.Helpers;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace AdminPanelService.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseModel{

        protected readonly Repasitory<T> _repository;

        protected readonly IResultBuilder _resultBuilder;

        protected readonly IMapper _mapper;

        protected readonly string _nameObject = typeof(T).Name;

        public BaseService(Repasitory<T> repository, IMapper mapper, IResultBuilder resultBuilder)
        {
            _repository = repository;
            _mapper = mapper;
            _resultBuilder = resultBuilder;
        }

        public abstract  Task<IResult> Delete(int id);

        public abstract Task<IResult> GetById(int id);

        public abstract Task<IResult> GetList();

        public abstract Task<IResult> Set(T obj);

        public abstract Task<IResult> Update(int id, T obj);

        public abstract Task<IResult> Path(int id, T obj);
    }
}
