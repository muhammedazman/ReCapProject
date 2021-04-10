using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryDal<Rental, RecapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RecapContext context = new RecapContext())
            {

                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join cus in context.Customers on r.CustomerId equals cus.CustomerId
                             select (new RentalDetailDto { 
                                    RentalId = r.RentalId,
                                    CustomerId = r.CustomerId,
                                    CarId = r.CarId,
                                    RentDate = r.RentDate,
                                    ReturnDate = r.ReturnDate,
                                    DailyPrice = c.DailyPrice,
                                    ModelYear = c.ModelYear,
                                    Description = c.Description,
                                    CustomerName = cus.CustomerName,
                                    Address = cus.Address
                             });


                return result.ToList();
            }
        }
    }
}
