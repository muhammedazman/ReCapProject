﻿using Business.Concrete;
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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            //CarUpdateTest(carManager);
            //CarAddTest(carManager, brandManager, colorManager);
            //CarSelectTest(carManager, brandManager, colorManager);
            //GetCarDetailTest(carManager);

            RentalDetailSelectTest(rentalManager);
            
            /*foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",
                    rental.CarId,
                    rental.CustomerId,
                    rental.RentalId,
                    rental.RentDate,
                    rental.ReturnDate);
            }*/
        }

        private static void RentalDetailSelectTest(RentalManager rentalManager)
        {
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                    rental.CarId,
                    rental.BrandName,
                    rental.ColorName,
                    rental.DailyPrice,
                    rental.ModelYear,
                    rental.Description,
                    rental.RentalId,
                    rental.RentDate.ToString("d"),
                    rental.ReturnDate.ToString("d") == "1.01.1754" ? " - ": rental.ReturnDate.ToString("d"),
                    rental.CustomerId,
                    rental.CustomerName,
                    rental.Address);
            }
        }

        private static void GetCarDetailTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                    car.CarId,
                    car.BrandName,
                    car.ColorName,
                    car.DailyPrice,
                    car.ModelYear,
                    car.Description);
            }
        }

        private static void CarUpdateTest(CarManager carManager)
        {
            carManager.Update(new Car
            {
                CarId = 7,
                BrandId = 2,
                ColorId = 1,
                ModelYear = 2009,
                DailyPrice = 2000,
                Description = "20210326-Update Transaction"
            });
        }

        private static void CarAddTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 21000,
                ModelYear = 2010,
                Description = "20210326-Add Transaction"
            });
        }

        private static void CarSelectTest(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1} {2} {3}",
                    car.CarId,
                    brandManager.GetById(car.BrandId).BrandName,
                    colorManager.GetById(car.ColorId).ColorName,
                    car.ModelYear,
                    car.DailyPrice);
            }
        }
    }
}
