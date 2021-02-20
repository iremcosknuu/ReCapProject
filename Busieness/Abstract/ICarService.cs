using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussienes.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> Get(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
