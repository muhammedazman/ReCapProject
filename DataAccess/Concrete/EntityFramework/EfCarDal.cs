using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryDal<Car, RecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cc in context.Colors on c.ColorId equals cc.ColorId
                             select (new CarDetailDto { 
                                 CarId = c.CarId, 
                                 BrandName = b.BrandName, 
                                 ColorName = cc.ColorName,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear
                             });

                return (List<CarDetailDto>) result.ToList();
            }
        }
    }
}
