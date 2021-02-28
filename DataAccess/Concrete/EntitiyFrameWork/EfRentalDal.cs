using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntitiyFrameWork
{
   public  class EfRentalDal:EfEntityRepositoryBase<Rental,RCProjectCarDatabaseContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RCProjectCarDatabaseContext context = new RCProjectCarDatabaseContext())
            {
                var result = from rental in context.Rentals
                             join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                             join u in context.Users on customer.UserId equals u.Id
                             join c in context.Cars on rental.CarId equals c.Id
                             select new RentalDetailDto { DetailId = 1, CarName = c.CarName, FirstName = u.FirstName, LastName = u.LastName, DailyPrice = c.DailyPrice,
                                 RentDate = rental.RentDate, ReturnDate = rental.ReturnDate, TotalPrice = rental.ReturnDate != default ? ((rental.ReturnDate.Subtract(rental.RentDate)).Days) * c.DailyPrice : 0};
                return result.ToList();
                      
                           
            }
        }
    }
}
