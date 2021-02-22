using AdminPanelService.Models;
using AdminPanelService.Models.DTOModels.Product;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductRead>()
                .ForMember(dest => dest.ProductPropertys, // куда мапим 
                                    opt => opt.MapFrom(src => src.ProductPropertysObject)); // что мапим
        }
    }
}
