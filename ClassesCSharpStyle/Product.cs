using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCSharpStyle
{
    public class Product
    {
        public static double VAT = 0.23;
        public double Price { get; set; }
        public double PriceWTax
        {
            get { return Price * (1 + VAT); }
            set { Price = value / (1 + VAT); }

        }
        //public double PriceWTax => Price * (1 + VAT);
    }
}
