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
    public class UserService : BaseService<UserModel>
    {
        public UserService(AppDbContext context) : base(context)
        {

        }

        public override async Task<IResult> Delete(long id)
        {
            var findUser = _context.User.ToList()
                                    .FirstOrDefault(x => x.Id == id);

            if(findUser == null)
            {
                return ErrorResult(
                    HttpStatusCode.NotFound,
                    EMessages.NotFoundElement,
                    _nameObject);
            }

            _context.User.Remove(findUser);
            await SaveChange();

            return OkResult(
                HttpStatusCode.OK,
                EMessages.ElementsIsFound,
                _nameObject);
        }

        public override  async Task<IResult> GetById(long id)
        {
            if (findUser == null)
            {
                return ErrorResult(
                    HttpStatusCode.NotFound,
                    EMessages.NotFoundElement,
                    _nameObject);
            }
        }

        public override async Task<IResult> GetList()
        {
            
        }

        public override async Task<IResult> Set(UserModel obj)
        {
            
        }

        public override async Task<IResult> Update(long id, UserModel obj)
        {
            
        }
    }
}
