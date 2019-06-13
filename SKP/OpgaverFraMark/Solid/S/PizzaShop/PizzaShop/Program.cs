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
            Pizza myPizza = new Pizza();
            StandardMessages.WelcomeMessage();
            StandardMessages.EndApplication();
                       
           StandardMessages.Topping();
            int choice = int.Parse(Console.ReadLine());
            string tempTop = "";
            switch (choice)
            {
                case 1:
                    tempTop = "Cheese";
                    break;
                case 2:
                    tempTop = "Pepperoni";
                    break;
                case 3:
                    tempTop = "Pineapple";
                    break;
                case 4:
                    tempTop = "Ham";
                    break;
                case 5:
                    tempTop = "Bacon";
                    break;
                case 6:
                    tempTop = "Salad";
                    break;
            }
            if (!tempTop.Equals(""))
            {
                myPizza.Toppings.Add(tempTop);
            }

            PizzaNameCapture.Capture();
            // Heat pizza
            Console.WriteLine("Now let's heat the pizza");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("... " + i);
            }
            ServePizza.Served(myPizza);
           
        }
    }
}
