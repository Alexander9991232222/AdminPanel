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
    public class ProductService : BaseService<Product>
    {
        public ProductService(Repasitory<Product> repasitory, IMapper mapper, IResultBuilder resultBuilder) : 
            base(repasitory, mapper, resultBuilder) 
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

        public override Task<IResult> Path(int id, Product obj)
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> Set(Product obj)
        {
            throw new NotImplementedException();
        }

        public override Task<IResult> Update(int id, Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
