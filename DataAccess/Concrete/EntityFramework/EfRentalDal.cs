using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using DatabaseContext context = new DatabaseContext();
            var result = from r in context.Rentals
                         join cr in context.Cars
                         on r.CarId equals cr.CarId
                         join cs in context.Customers
                         on r.CustomerId equals cs.CustomerId
                         join br in context.Brands
                         on cr.BrandId equals br.BrandId
                         join u in context.Users
                         on cs.UserId equals u.Id
                         select new RentalDetailDto { RentalId = r.RentalId, BrandName = br.BrandName, CustomerName = u.FirstName + u.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
            return result.ToList();
        }
    }
}