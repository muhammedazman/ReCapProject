using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IColorDal
    {
        List<Color> GetAll();
        string GetColorName(int colorId);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
