using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {

        }
        public override decimal GetCost()
        {
            var cost = _beverage.GetCost() + 0.4m;
            return cost;
        }
    }
}
