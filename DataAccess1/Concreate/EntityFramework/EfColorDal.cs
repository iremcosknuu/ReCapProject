using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color,CarRentalContext>,IColorDal
    {
    }
}
