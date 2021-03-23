using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2019, DailyPrice=21000, Description="Yeni gibi"},
                new Car{CarId=2, BrandId=7, ColorId=3, ModelYear=2020, DailyPrice=18000, Description="Hasarli"},
                new Car{CarId=3, BrandId=2, ColorId=5, ModelYear=2001, DailyPrice=1000, Description="Uzun yol araci"},
                new Car{CarId=4, BrandId=4, ColorId=7, ModelYear=2008, DailyPrice=10000, Description="taksi"},
                new Car{CarId=5, BrandId=3, ColorId=2, ModelYear=2007, DailyPrice=8000, Description="5.el"},
                new Car{CarId=6, BrandId=3, ColorId=4, ModelYear=2006, DailyPrice=5000, Description="tamir görmüs"},
                new Car{CarId=7, BrandId=4, ColorId=6, ModelYear=2005, DailyPrice=15000, Description="ic dekorasyon güzel"},
                new Car{CarId=8, BrandId=5, ColorId=8, ModelYear=2021, DailyPrice=50000, Description="sifir"},
                new Car{CarId=9, BrandId=6, ColorId=9, ModelYear=2021, DailyPrice=45000, Description="sifir gibi"}
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car filteredCar = (Car) _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            filteredCar.BrandId = car.BrandId;
            filteredCar.ColorId = car.ColorId;
            filteredCar.ModelYear = car.ModelYear;
            filteredCar.DailyPrice = car.DailyPrice;
            filteredCar.Description = car.Description;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }
    }
}
