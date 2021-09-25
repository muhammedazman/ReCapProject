using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            if (BrandNameControl(brand))
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandListed);
            }
            else
            {
                return new ErrorResult(Messages.BrandNameCharacterCount);
            }
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var result = _brandDal.Get(p=>p.BrandId==brandId);
            return new SuccessDataResult<Brand>(result);
        }

        public IResult Update(Brand brand)
        {
            if (BrandNameControl(brand))
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.BrandUpdated);
            }
            else
            {
                return new ErrorResult(Messages.BrandNameCharacterCount);
            }
        }

        private static bool BrandNameControl(Brand brand)
        {
            return brand.BrandName.Length > 2;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }
    }
}
