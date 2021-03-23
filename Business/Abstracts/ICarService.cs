using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
