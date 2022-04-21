namespace Decorator
{
    class Coffee : IBeverage
    {
        public decimal GetCost()
        {
            return 1.5m;
        }
    }
}
