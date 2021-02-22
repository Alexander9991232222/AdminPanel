using AdminPanelService.Data;
using AdminPanelService.Models;
using AdminPanelService.Models.DTOModels.Product;
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

        public async override Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async override Task<IResult> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async override Task<IResult> GetList()
        {
            var listResult = await _repository.QueryToProcedureAsync<List<Product>>("dbo.GET_PRODUCT_LIST");
            var mappedList  = _mapper.Map<List<ProductRead>>(listResult);

            return _resultBuilder.OkResult(
                    EMessages.ElementsIsFound,
                    _nameObject, mappedList);
        }

        public async override Task<IResult> Path(int id, Product obj)
        {
            throw new NotImplementedException();
        }

        public async override Task<IResult> Set(Product obj)
        {
            throw new NotImplementedException();
        }

        public async override Task<IResult> Update(int id, Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
