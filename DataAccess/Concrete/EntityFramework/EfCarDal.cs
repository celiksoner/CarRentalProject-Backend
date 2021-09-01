using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using DatabaseContext context = new DatabaseContext();
            var result = from c in context.Cars
                         join b in context.Brands
                         on c.BrandId equals b.BrandId
                         join clr in context.Colors
                         on c.ColorId equals clr.ColorId
                         select new CarDetailDto { CarId = c.CarId, BrandId = c.BrandId, ModelName = c.ModelName, BrandName = b.BrandName, DailyPrice = c.DailyPrice, Description = c.Description, ColorName = clr.ColorName, ModelYear = c.ModelYear, CarImage = (from i in context.CarImages where (c.CarId == i.CarId) select i.ImagePath).FirstOrDefault() };
            return filter == null ? result.ToList() : result.Where(filter).ToList();
        }
    }
}