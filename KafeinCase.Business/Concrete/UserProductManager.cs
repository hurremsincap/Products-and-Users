using System.Collections.Generic;
using KafeinCase.Business.Abstract;
using KafeinCase.DataAccess.Abstract;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Business.Concrete
{
    public class UserProductManager : IUserProductService
    {
        private IUserProductDal _userProductDal;

        public UserProductManager(IUserProductDal userProductDal)
        {
            _userProductDal = userProductDal;
        }

        public UserProduct AddUserProduct(UserProduct userProduct)
        {
            return _userProductDal.Add(userProduct);
        }
    }
}
