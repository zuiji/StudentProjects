using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages ms = new StandardMessages();
            ms.WelcomeMessage();

            ms.EndApplication();
            PizzaInfoCapture PIC = new PizzaInfoCapture();
            Pizza myPizza = PIC.Capture();

            ms.Topping();
            PIC.Topping(myPizza);
           
            StandardMessages.ServePizza();

            
            
            ServePizza sp = new ServePizza();
            sp.Served(myPizza);

        }
    }
}
