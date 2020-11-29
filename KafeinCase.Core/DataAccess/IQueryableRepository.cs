using KafeinCase.Core.Entities;
using System.Linq;

namespace KafeinCase.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
