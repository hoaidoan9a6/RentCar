using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
    where TEntity: class, IEntity, new()
    where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
                SetInsertOFF(context);
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;

                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }

        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void SetInsertON(TContext context)
        {
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Cars ON");
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Colors ON");
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Brands ON");
        }

        public void SetInsertOFF(TContext context)
        {
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Cars OFF");
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Colors OFF");
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Brands OFF");
        }
    }
}
