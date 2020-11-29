using System.Collections.Generic;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.Business.Abstract
{
    public interface IUserProductService
    {
        UserProduct AddUserProduct(UserProduct userProduct);
    }
}
