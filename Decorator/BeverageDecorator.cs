namespace Decorator
{
    abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage _beverage;

        public BeverageDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public abstract decimal GetCost();
    }
}