using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
