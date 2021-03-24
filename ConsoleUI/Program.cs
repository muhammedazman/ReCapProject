using Business.Concrete;
using DataAccess.Abstracts;
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
            ICarDal inMemoryCarDal = new InMemoryCarDal();
            IBrandDal inMemoryBrandDal = new InMemoryBrandDal();
            IColorDal inMemoryColorDal = new InMemoryColorDal();

            CarManager carManager = new CarManager(inMemoryCarDal, inMemoryBrandDal, inMemoryColorDal);
            List<Car> cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.Write(car.CarId+" | "+ carManager.GetBrandName(car.BrandId) + " | " + carManager.GetColorName(car.ColorId) + "\n");
            }
        }
    }
}
