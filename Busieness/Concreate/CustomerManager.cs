using Busieness.Abstract;
using Busieness.Constrants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concreate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            try
            {
                _customerDal.Delete(customer);
                return new SuccessResult(Messages.CustomerDeleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.CustomerNotDeleted);
            }
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll() ,Messages.CustomerListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>((_customerDal.Get(c => c.CustomerId == id)), Messages.CustomerListed);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails(),Messages.CustomerListed);
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
