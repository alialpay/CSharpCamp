using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from ren in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on ren.Id equals c.Id
                             join cus in context.Customers
                             on ren.CustomerId equals cus.UserId
                             join us in context.Users
                             on cus.UserId equals us.Id
                             join b in context.Brands
                             on c.Id equals b.BrandId


                             select new RentalDetailDto
                             {
                                 CarBrand = b.BrandName,
                                 UserName = us.FirstName,
                                 CustomerName = cus.CompanyName,
                                 RentalDate = ren.RentalDate,
                                 ReturnDate = ren.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
