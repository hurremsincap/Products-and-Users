using KafeinCase.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace KafeinCase.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        // IEntityRepository interface'indeki fonksiyonların implementasyonu
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntry = context.Entry(entity);
                addedEntry.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var deletedEntry = context.Entry(entity);
                    deletedEntry.State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteAllById(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                using (var context = new TContext())
                {
                    var entities = context.Set<TEntity>().Where(filter);
                    foreach (var entity in entities)
                    {
                        var deletedEntry = context.Entry(entity);
                        deletedEntry.State = EntityState.Deleted;
                    }
                    context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteById(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                using (var context = new TContext())
                {
                    var entity = context.Set<TEntity>().FirstOrDefault(filter);
                    var deletedEntry = context.Entry(entity);
                    deletedEntry.State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                //return filter == null
                //    ? context.Set<TEntity>().ToList()
                //    : context.Set<TEntity>().Where(filter).ToList();
                if (filter == null) // koşul yoksa verileri direk listeleyip döndür
                {
                    return context.Set<TEntity>().ToList();
                }
                else // verileri filterladıktan sonra listeleyip döndür
                {
                    return context.Set<TEntity>().Where(filter).ToList();
                }
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntry = context.Entry(entity);
                updatedEntry.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }

    }
}
