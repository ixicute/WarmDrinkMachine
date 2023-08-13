using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($">>Pour {total} ml hot coffee in your cup");
            Thread.Sleep(1500);
            Console.WriteLine($">>Pour {total / 4} ml milk in your cup");
            Console.WriteLine(new string('-', 28));
            return new Coffee();
        }
    }
}
