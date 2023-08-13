using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class CappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($">>Pour {total / 2} ml espresso in your cup");
            Thread.Sleep(1000);
            Console.WriteLine($">>Pour {total / 3} ml warm milk in your cup");
            Thread.Sleep(1000);
            Console.WriteLine($">>Pour {total / 4} ml milk foam in your cup");
            Console.WriteLine(new string('-', 28));
            return new Cappuccino();
        }
    }
}
