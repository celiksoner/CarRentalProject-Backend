using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        
        public List<CarDetailDto> GetCarDetails()
        {
            using DatabaseContext context = new();
            var result = from c in context.Cars
                         join b in context.Brands                
                         on c.BrandId equals b.BrandId
                         join clr in context.Colors
                         on c.ColorId equals clr.ColorId
                         select new CarDetailDto { CarId = c.CarId, ModelName = c.ModelName, BrandName = b.BrandName, DailyPrice = c.DailyPrice, Description = c.Description, ColorName = clr.ColorName, ModelYear = c.ModelYear};
            return result.ToList();
        }    
     
    }
}
