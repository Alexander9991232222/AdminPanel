using AdminPanelService.Models;
using AdminPanelService.Models.DTOModels.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserCreate>();
            CreateMap<User, UserUpdate>();
            CreateMap<User, UserPath>();
            CreateMap<User, UserRead>();
        }
    }
}
