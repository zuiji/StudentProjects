using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            // Pizza shop
            Console.WriteLine("Welcome to the pizza shop");
            Console.WriteLine("Here you can make your own pizza");
            // Begin creating a pizza
            Console.WriteLine("Press Enter to begin creating a pizza");

        }

        public static void EndApplication()
        {
            
            Console.ReadLine();
        }

        public static void Topping()
        {
            // Add topping
            Console.WriteLine("Choose topping to add:");
            Console.WriteLine("1) Cheese");
            Console.WriteLine("2) Pepperoni");
            Console.WriteLine("3) Pineapple");
            Console.WriteLine("4) Ham");
            Console.WriteLine("5) Bacon");
            Console.WriteLine("6) Salad");
        }
    }
}
