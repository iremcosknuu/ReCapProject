using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=2010,Description="Manuel Benzinli"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=299.99,ModelYear=2013,Description="Otomatik Benzinli"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=450.15,ModelYear=2015,Description="Otomatik Benzinli"},
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=485.50,ModelYear=2018,Description="Manuel Dizel"},
                new Car{Id=5,BrandId=3,ColorId=4,DailyPrice=500,ModelYear=2020,Description="Otomatik Dizel"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

    
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id );
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
