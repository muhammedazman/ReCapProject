using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (BrandNameControl(brand))
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Error: Brand Name have to 2 Character than bigger");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(p=>p.BrandId==brandId);
        }

        public void Update(Brand brand)
        {
            if (BrandNameControl(brand))
            {
                _brandDal.Update(brand);
            }
            else
            {
                Console.WriteLine("Error: Brand Name have to 2 Character than bigger");
            }
        }

        private static bool BrandNameControl(Brand brand)
        {
            return brand.BrandName.Length > 2;
        }
    }
}
