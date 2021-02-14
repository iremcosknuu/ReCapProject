using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);    //Referansı yakalar 
                addedEntity.State = EntityState.Added;      //Nesneyi ekle
                context.SaveChanges();                      //yapılanları kaydetme
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);       //Referansı yakalar 
                deletedEntity.State = EntityState.Deleted;       //Nesneyi siler
                context.SaveChanges();                           //yapılanları kaydetme
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                //filtre zorunludur ve filtreden geçen veri döndürülür
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //filter zorunlu değildir
                return
                    filter == null ?
                    context.Set<TEntity>().ToList() :                 //filter null ise bütün verileri listeler
                    context.Set<TEntity>().Where(filter).ToList();    //filter var ise veriyi filtrelerek listeler
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);       //Referansı yakalar 
                updatedEntity.State = EntityState.Modified;      //Nesneyi günceller
                context.SaveChanges();                           //yapılanları kaydetme
            }
        }

    }
}
