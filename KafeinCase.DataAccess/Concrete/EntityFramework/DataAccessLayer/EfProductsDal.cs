using KafeinCase.DataAccess.Abstract;
using KafeinCase.Core.DataAccess.EntityFramework;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.DataAccess.Concrete.EntityFramework.DataAccessLayer
{
    public class EfProductsDal : EfEntityRepositoryBase<Products, KafeinContext>, IProductsDal
    {
    }
}
