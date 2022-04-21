
namespace Decorator
{
    class CognacDecorator : BeverageDecorator
    {
        public CognacDecorator(IBeverage bevarage) : base(bevarage)
        {

        }

        public override decimal GetCost()
        {
            var cost = _beverage.GetCost() + 0.5m;
            return cost;
        }
    }
}
