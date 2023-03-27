using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Facade.ServItems
{
    internal class Price
    {
        public double ComputePrice(int dishesCount)
        {
            return 50 * dishesCount;
        }
        public double ComputeDiscount(double price,int discount)
        {
            return price-=price * discount/100;
        }
        public int GetDiscount(int dishesCount)
        {
            if (dishesCount > 3)
            {
                return 20;
            }
            if (dishesCount > 2)
            {
                return 5;
            }
            return 1;
        }
    }
}
