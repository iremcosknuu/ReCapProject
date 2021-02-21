using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarRentalContext context =new CarRentalContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.UserId equals user.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId=customer.CustomerId,
                                 UserId=user.UserId,
                                 FirstName=user.FirstName,
                                 LastName=user.LastName,
                                 Email=user.Email,
                                 CompanyName=customer.CompanyName,
                             };
                return result.ToList();
            }
            
        }
    }
}
