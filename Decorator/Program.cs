using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage coffee = new Coffee();
            coffee = new CaramelDecorator(coffee);
            coffee = new MilkDecorator(coffee);
            coffee = new CognacDecorator(coffee);

            Console.WriteLine("Cost is " + coffee.GetCost());
        }
    }
}
