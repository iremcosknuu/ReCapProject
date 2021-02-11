using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var addedEntity = context.Entry(entity);   //Referansı yakalar 
                addedEntity.State = EntityState.Added;  //Nesneyi ekle
                context.SaveChanges();                  //yapılanları kaydetme
            }
        }

        public void Delete(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);       //Referansı yakalar 
                deletedEntity.State = EntityState.Deleted;    //Nesneyi siler
                context.SaveChanges();                      //yapılanları kaydetme
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                //filtre zorunludur ve filtreden geçen veri döndürülür
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                //filter zorunlu değildir
                return 
                    filter == null ? 
                    context.Set<Car>().ToList() :                 //filter null ise bütün verileri listeler
                    context.Set<Car>().Where(filter).ToList();    //filter var ise veriyi filtrelerek listeler
            }
        }

        public void Update(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);       //Referansı yakalar 
                updatedEntity.State = EntityState.Modified;   //Nesneyi günceller
                context.SaveChanges();                      //yapılanları kaydetme
            }
        }
    }
}
