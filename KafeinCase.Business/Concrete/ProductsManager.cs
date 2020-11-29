using System.Collections.Generic;
using KafeinCase.Business.Abstract;
using KafeinCase.DataAccess.Abstract;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Business.Concrete
{
    public class ProductsManager : IProductsService
    {
        private IProductsDal _productsDal;

        public ProductsManager(IProductsDal productsDal)
        {
            _productsDal = productsDal;
        }
        public List<Products> GetAll()
        {
            return _productsDal.GetList();
        }
       
    }
}
