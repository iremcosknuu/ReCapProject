using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetById(int Id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
