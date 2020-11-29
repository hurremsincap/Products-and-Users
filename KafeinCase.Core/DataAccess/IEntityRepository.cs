using KafeinCase.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KafeinCase.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null); // veriyi liste olarak alma, filter = where clause
        T Get(Expression<Func<T, bool>> filter); // tek veri alma, filter = where clause
        T Add(T entity); // veri ekleme, entity = primary key
        T Update(T entity); // veri güncelleme, entity = primary key
        bool Delete(T entity); // veri silme, entity = primary key 
        bool DeleteById(Expression<Func<T, bool>> filter); // Veri silme, id bazında
        bool DeleteAllById(Expression<Func<T, bool>> filter); // Veri silme, id bazında
    }
}
