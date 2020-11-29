using KafeinCase.Core.Entities;
using System.Data.Entity;
using System.Linq;

namespace KafeinCase.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context; // herhangi bir framework contexti
        private IDbSet<T> _entities; // gönderilecek tablo
        public EfQueryableRepository(DbContext context) // bağımlılığı ortadan kaldırmak için dependancy injection
        {
            _context = context;
        }
        public IQueryable<T> Table => this.Entities;
        protected virtual IDbSet<T> Entities // gönderilecek tablonun implementasyonu
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;

            }
        }
    }
}
