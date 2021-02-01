using AdminPanelService.Data;
using AdminPanelService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Services
{
    public class AvatarController : BaseService<ImageAvatar>
    {
        public AvatarController(Repasitory<ImageAvatar> repasitory, IMapper mapper) : base(repasitory, mapper)
        {

        }

        public override Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> GetList()
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> Path(int id, ImageAvatar obj)
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> Set(ImageAvatar obj)
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> Update(int id, ImageAvatar obj)
        {
            throw new NotImplementedException();
        }
    }
}
