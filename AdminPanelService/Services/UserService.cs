using AdminPanelService.Data;
using AdminPanelService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using AutoMapper;
using AdminPanelService.Models.DTOModels.User;

namespace AdminPanelService.Services
{
    public class UserService : BaseService<User>
    {
        public UserService(Repasitory<User> repasitory, IMapper mapper, IResultBuilder resultBuilder) 
            : base(repasitory, mapper, resultBuilder)
        {

        }

        public override async Task<IResult> Delete(int id)
        {
            var findElement = await _repository.GetByIdAsync(id);

            if (findElement is null)
            {
                return _resultBuilder.NotFoundResult(EMessages.NotFoundElement, _nameObject);
            }

            _repository.Remove(findElement);
            await _repository.SaveChangeAsync();

            return _resultBuilder.OkResult(EMessages.ElementsIsFound, _nameObject);
        }

        public override  async Task<IResult> GetById(int id)
        {
             var findElement = await _repository.GetByIdAsync(id);

            if(findElement is null)
            {
                return  _resultBuilder.NotFoundResult(EMessages.NotFoundElement, _nameObject);
            }

            return _resultBuilder.OkResult(EMessages.ElementsIsFound, _nameObject, 
                _mapper.Map<UserRead>(findElement));
        }

        public override async Task<IResult> GetList()
        {
            return _resultBuilder.OkResult(EMessages.ElementsIsFound, _nameObject,
                _mapper.Map<IEnumerable<UserRead>>(await _repository.GetListAsync()));
        }

        public override async Task<IResult> Set(User obj)
        {
            try
            {
                await _repository.AddAsync(obj);
                await _repository.SaveChangeAsync();
                return _resultBuilder.OkResult(EMessages.ElementIsAddSuccess, _nameObject);
            }
            catch 
            {
                return _resultBuilder.ErrorResult(EMessages.ElementIsNotAdd, _nameObject);
            }
        }

        public override async Task<IResult> Update(int id, User obj)
        {
            try
            {
                _repository.Update(id, obj);
                await _repository.SaveChangeAsync();
                return _resultBuilder.OkResult(EMessages.ElementIsUpdate, _nameObject);
            }
            catch
            {
                return _resultBuilder.InternalServerError(EMessages.ElementIsNotUpdate, nameObject: _nameObject);
            }
        }

        public override async Task<IResult> Path(int id, User obj)
        {

            var findElement = await _repository.GetByIdAsync(id);

            if(findElement is null)
            {
                return _resultBuilder.ErrorResult(EMessages.ElementIsNotUpdate, _nameObject);
            }

            _repository.Update(id, obj);
            await _repository.SaveChangeAsync();
            return _resultBuilder.OkResult(EMessages.ElementIsUpdate, _nameObject);
        }
    }
}
