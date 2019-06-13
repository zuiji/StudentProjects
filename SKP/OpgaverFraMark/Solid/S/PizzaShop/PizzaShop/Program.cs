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
            PIC.Topping();
            bool isToppingValid = PIC.Topping(myPizza);
            if (!isToppingValid == false)
            {
                myPizza.Toppings.Add(tempTop);
            }

            

            // Heat pizza
            Console.WriteLine("Now let's heat the pizza");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("... " + i);
            }
            
            ServePizza sp = new ServePizza();
            sp.Served(myPizza);

        }
    }
}
