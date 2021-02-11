using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int Id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
