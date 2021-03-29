using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (DailyPriceControl(car))
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("ERROR: Daily Price have to 0 than bigger");
            }
        }

        private static bool DailyPriceControl(Car car)
        {
           return car.DailyPrice > 0;         
        }

        public void Delete(Car car)
        { 
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _carDal.GetAll(p=>p.BrandId==brandId);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public void Update(Car car)
        {
            if (DailyPriceControl(car))
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("ERROR: Daily Price have to 0 than bigger");
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
