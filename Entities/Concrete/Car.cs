using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        private decimal _dailyPriceFormat;
            

        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice
        { 
            get { return _dailyPriceFormat; } 
            set { _dailyPriceFormat = Convert.ToDecimal(string.Format("{0:#.00}", Convert.ToDecimal(value))); }
        }

        public string Description { get; set; }
    }
}
