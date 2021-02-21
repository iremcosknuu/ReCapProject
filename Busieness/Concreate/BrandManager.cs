using Busieness.Abstract;
using Busieness.Constrants;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandNotAdded);
            }
            else
            {
                return new ErrorResult(Messages.BrandAdded);
            }
        }

        public IResult Delete(Brand brand)
        {
            try
            {
                _brandDal.Delete(brand);
                return new SuccessResult(Messages.BrandDeleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.BrandNotDeleted);
            }
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id),Messages.BrandListed);
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length >=2)
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.BrandUpdated);
            }
            else
            {
                return new ErrorResult(Messages.BrandNotAdded);
            }
        }
    }
}
