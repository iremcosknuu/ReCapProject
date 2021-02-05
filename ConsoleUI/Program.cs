using Bussienes.Concreate;
using DataAccess.Concreate;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba Id: "+car.Id);
                Console.WriteLine("Araba Markası Id: "+car.BrandId);
                Console.WriteLine("Araba Renk Id: "+car.ColorId);
                Console.WriteLine("Araba Modeli: "+car.ModelYear);
                Console.WriteLine("Günlük Kiralama Ücreti: "+car.DailyPrice);
                Console.WriteLine("Açıklama: "+car.Description);
                Console.WriteLine("********************************************");
            }
            Console.WriteLine("Yeni bilgi girişi için 1 i");
            Console.WriteLine("Bilgi güncellmek için 2 yi");
            Console.WriteLine("Silme işlemi için 3 ü");
            Console.WriteLine("Id ile listelemek için 4 ü tuşlayınız");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    
                    carManager.Add(new Car
                    {
                        Id = Convert.ToInt32(Console.ReadLine()),
                        BrandId = Convert.ToInt32(Console.ReadLine()),
                        ColorId = Convert.ToInt32(Console.ReadLine()),
                        ModelYear = Convert.ToInt32(Console.ReadLine()),
                        DailyPrice = Convert.ToInt64(Console.ReadLine()),
                        Description = Console.ReadLine()
                    });
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
                    break;
                case 2:
                    Console.WriteLine("Güncellemek isteğiniz bilginin id sini giriniz: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    carManager.Update(new Car
                    {
                        Id=updateId,
                        BrandId = Convert.ToInt32(Console.ReadLine()),
                        ColorId = Convert.ToInt32(Console.ReadLine()),
                        ModelYear = Convert.ToInt32(Console.ReadLine()),
                        DailyPrice = Convert.ToInt64(Console.ReadLine()),
                        Description = Console.ReadLine()
                    });
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
                    break;
                case 3:
                    Console.WriteLine("Silmek isteğiniz bilginin id sini giriniz: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());
                    carManager.Delete(new Car { Id=deleteId});
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
                    break;
                case 4:
                    Console.WriteLine("Listelemek isteğiniz bilginin id sini giriniz: ");
                    int byId = Convert.ToInt32(Console.ReadLine());
                    foreach (var car in carManager.GetById(byId))
                    {
                        Console.WriteLine("Araba Id: " + car.Id);
                        Console.WriteLine("Araba Markası Id: " + car.BrandId);
                        Console.WriteLine("Araba Renk Id: " + car.ColorId);
                        Console.WriteLine("Araba Modeli: " + car.ModelYear);
                        Console.WriteLine("Günlük Kiralama Ücreti: " + car.DailyPrice);
                        Console.WriteLine("Açıklama: " + car.Description);
                        Console.WriteLine("********************************************");
                    }
                    break;


            }
        }
    }
}
