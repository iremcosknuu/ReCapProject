using Busieness.Concreate;
using Bussienes.Concreate;
using DataAccess.Concreate.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Araba Id: " + car.CarId);
                Console.WriteLine("Araba Adı Id: " + car.CarName);
                Console.WriteLine("Araba Rengi: " + car.ColorName);
                Console.WriteLine("Araba Markası: " + car.BrandName);
                Console.WriteLine("Günlük Kiralama Ücreti: " + car.DailyPrice);
                Console.WriteLine("********************************************");
            }

   
        }

       
        }
}

