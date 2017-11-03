using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SalesPurchase : Purchase, IPurchase
    {
        public SalesPurchase(Product x, int y) : base(x, y)
        {
        }

        public override double Calculate()
        {
            return base.Calculate() * 0.9;
        }
    }
}
