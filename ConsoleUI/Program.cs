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
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            InMemoryBrandDal inMemoryBrandDal = new InMemoryBrandDal();
            InMemoryColorDal inMemoryColorDal = new InMemoryColorDal();

            CarManager carManager = new CarManager(inMemoryCarDal, inMemoryBrandDal, inMemoryColorDal);
            List<Car> cars = carManager.GetAll();

            foreach (var car in cars)
            {
                Console.Write(car.CarId+" -- "+ inMemoryBrandDal.GetBrandName(car.BrandId) + " -- " + inMemoryColorDal.GetColorName(car.ColorId) + "\n");
            }
        }
    }
}
