using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class ChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($">>Pour {total / 4} granulated sugar in your cup");
            Thread.Sleep(500);
            Console.WriteLine($">>Pour {total / 3} ml coco powder in your cup");
            Thread.Sleep(1000);
            Console.WriteLine($">>Pour {total} ml hot milk in your cup");
            Console.WriteLine(new string('-', 28));
            return new Chocolate();
        }
    }
}
