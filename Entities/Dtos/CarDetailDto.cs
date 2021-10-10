using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CarDetailDto:IDto
    {
        private decimal _dailyPriceFormat;

        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice
        {
            get { return _dailyPriceFormat; }
            set { _dailyPriceFormat = Convert.ToDecimal(string.Format("{0:#.00}", Convert.ToDecimal(value))); }
        }

        public string Description { get; set; }
    }
}
