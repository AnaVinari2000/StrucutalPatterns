namespace Decorator
{
    class CaramelDecorator : BeverageDecorator
    {
        public CaramelDecorator(IBeverage beverage) : base(beverage)
        {

        }

        public override decimal GetCost()
        {
            var cost = _beverage.GetCost() + 0.5m;

            return cost;
        }
    }
}
