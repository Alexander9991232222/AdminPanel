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
        public UserService(Repasitory<User> repasitory, IMapper mapper) : base(repasitory, mapper)
        {

        }

        public override async Task<IResult> Delete(int id)
        {
            var findElement = await _repository.GetByIdAsync(id);

            if (findElement is null)
            {
                return ErrorResult(code: HttpStatusCode.NotFound,
                                   message: EMessages.NotFoundElement,
                                   nameObject: _nameObject);
            }

            _repository.Remove(findElement);
            await _repository.SaveChangeAsync();

            return OkResult(message: EMessages.ElementsIsFound,
                _nameObject);
        }

        public override  async Task<IResult> GetById(int id)
        {
             var findElement = await _repository.GetByIdAsync(id);

            if(findElement is null)
            {
                return ErrorResult(code: HttpStatusCode.NotFound,
                                message: EMessages.NotFoundElement,
                                nameObject: _nameObject);
            }

            return OkResult(message: EMessages.ElementsIsFound,
                nameObject: _nameObject,
                data: _mapper.Map<UserRead>(findElement));
        }

        public override async Task<IResult> GetList()
        {
            return OkResult(message: EMessages.ElementsIsFound,
                nameObject: _nameObject,
                data: _mapper.Map<IEnumerable<UserRead>>(await _repository.GetListAsync()));
        }

        public override async Task<IResult> Set(User obj)
        {
            try
            {
                

                await _repository.AddAsync(obj);
                await _repository.SaveChangeAsync();
                return OkResult(message: EMessages.ElementIsAddSuccess,
                          nameObject: _nameObject);
            }
            catch 
            {
                return ErrorResult(code: HttpStatusCode.InternalServerError,
                        message: EMessages.ElementIsNotAdd,
                        nameObject: _nameObject);
            }
        }

        public override async Task<IResult> Update(int id, User obj)
        {
            try
            {
                _repository.Update(id, obj);
                await _repository.SaveChangeAsync();
                return OkResult(message: EMessages.ElementIsUpdate,
                          nameObject: _nameObject);
            }
            catch
            {
                return ErrorResult(code: HttpStatusCode.InternalServerError,
                        message: EMessages.ElementIsNotUpdate,
                        nameObject: _nameObject);
            }
        }

        public override async Task<IResult> Path(int id, User obj)
        {

            var findElement = await _repository.GetByIdAsync(id);

            if(findElement is null)
            {
                return ErrorResult(code: HttpStatusCode.InternalServerError,
                       message: EMessages.ElementIsNotUpdate,
                       nameObject: _nameObject);
            }

            _repository.Update(id, obj);
            await _repository.SaveChangeAsync();
            return OkResult(message: EMessages.ElementIsUpdate,
                        nameObject: _nameObject);
        }
    }
}
