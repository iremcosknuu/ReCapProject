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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba Id: " + car.Id);
                Console.WriteLine("Araba Markası Id: " + car.BrandId);
                Console.WriteLine("Araba Renk Id: " + car.ColorId);
                Console.WriteLine("Araba Modeli: " + car.ModelYear);
                Console.WriteLine("Günlük Kiralama Ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklama: " + car.Description);
                Console.WriteLine("********************************************");
            }

   
        }

       
        }
    }
}
