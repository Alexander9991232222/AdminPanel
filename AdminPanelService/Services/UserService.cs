using AdminPanelService.Data;
using AdminPanelService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AdminPanelService.Services
{
    public class UserService : BaseService<User>
    {
        public UserService(Repasitory<User> repasitory) : base(repasitory)
        {

        }

        public override async Task<IResult> Delete(int id)
        {
            try
            {
                await _repository.Remove(id);
                await _repository.SaveChangeAsync();

                return OkResult(
                    code: HttpStatusCode.OK,
                    message: EMessages.ElementsIsFound,
                    _nameObject);
            }
            catch
            {
                return ErrorResult(
                                   code: HttpStatusCode.NotFound,
                                   message: EMessages.NotFoundElement,
                                   nameObject: _nameObject);
            }       
        }

        public override  async Task<IResult> GetById(int id)
        {
            try
            {
                var element = await _repository.GetByIdAsync(id);

                return OkResult(
                    code: HttpStatusCode.OK,
                    message: EMessages.ElementsIsFound,
                    nameObject: _nameObject,
                    data: element);
            }
            catch
            {
                return ErrorResult(
                                   code: HttpStatusCode.NotFound,
                                   message: EMessages.NotFoundElement,
                                   nameObject: _nameObject);
            }
        }

        public override async Task<IResult> GetList()
        {
            return OkResult(
                code: HttpStatusCode.OK,
                message: EMessages.ElementsIsFound,
                nameObject: _nameObject,
                data: await _repository.GetListAsync());
        }

        public override async Task<IResult> Set(User obj)
        {
            try
            {
                await _repository.AddAsync(obj);
                await _repository.SaveChangeAsync();
                return OkResult(
                          code: HttpStatusCode.OK,
                          message: EMessages.ElementIsAddSuccess,
                          nameObject: _nameObject);
            }
            catch 
            {
                return ErrorResult(
                        code: HttpStatusCode.InternalServerError,
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
                return OkResult(
                          code: HttpStatusCode.OK,
                          message: EMessages.ElementIsUpdate,
                          nameObject: _nameObject);
            }
            catch
            {
                return ErrorResult(
                        code: HttpStatusCode.InternalServerError,
                        message: EMessages.ElementIsNotUpdate,
                        nameObject: _nameObject);
            }
        }
    }
}
