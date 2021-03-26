using Business.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            /*
            carManager.Update(new Car {
                CarId=7, 
                BrandId=2, 
                ColorId=1,
                DailyPrice=2000,
                Description="20210326-Update Transaction"
            });
            */

            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 21000,
                Description = "20210326-Add Transaction"
            });
            foreach (var car in carManager.GetAll()) { 
                Console.WriteLine("{0} {1} {2} {3}", 
                    car.CarId, 
                    brandManager.GetById(car.BrandId).BrandName, 
                    colorManager.GetById(car.ColorId).ColorName,
                    car.DailyPrice);
            }
        }
    }
}
