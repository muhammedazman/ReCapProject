﻿using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId=1, BrandName="Audi"},
                new Brand{BrandId=2, BrandName="BMW"},
                new Brand{BrandId=3, BrandName="Mercedes - AMG"},
                new Brand{BrandId=4, BrandName="Mercedes - Benz"},
                new Brand{BrandId=5, BrandName="Opel"},
                new Brand{BrandId=6, BrandName="Porsche"},
                new Brand{BrandId=7, BrandName="Volkswagen"}
            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public string GetBrandName(int brandId)
        {
            Brand filteredBrand = (Brand)_brands.SingleOrDefault(p => p.BrandId == brandId);
            return filteredBrand.BrandName;
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(p => p.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
