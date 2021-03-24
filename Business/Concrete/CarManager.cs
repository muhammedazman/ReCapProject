using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;

        public CarManager(ICarDal carDal, IBrandDal brandDal, IColorDal colorDal)
        {
            _colorDal = colorDal;
            _brandDal = brandDal;
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public string GetBrandName(int brandId)
        {
            return _brandDal.GetBrandName(brandId);
        }

        public string GetColorName(int colorId)
        {
            return _colorDal.GetColorName(colorId);
        }
    }
}
