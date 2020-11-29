using KafeinCase.Core.DataAccess;
using KafeinCase.Entities.Concrete;

namespace KafeinCase.DataAccess.Abstract
{
    public interface IUsersDal : IEntityRepository<Users>
    {
    }
}
