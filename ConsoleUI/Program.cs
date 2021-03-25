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

            foreach (var car in carManager.GetByDailyPrice(2000, 15000)) { 
                Console.WriteLine("{0} {1} {2}", car.CarId, car.BrandId, car.DailyPrice);
            }
        }
    }
}
