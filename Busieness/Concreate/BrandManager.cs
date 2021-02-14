using Busieness.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concreate
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka bilgileri başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Lütfen Marke adını 2 karakterden fazla olacak şekilde giriniz");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka bilgileri başarıyla silinmiştir.");  
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetById(int Id)
        {
            return _brandDal.GetAll(b=> b.BrandId == Id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >=2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka bilgileri başarıyla güncellenmiştir");
            }
            else
            {
                Console.WriteLine("Lütfen Marke adını 2 karakterden fazla olacak şekilde giriniz");
            }
        }
    }
}
