using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class ServePizza
    {
        public void Served(Pizza myPizza)
        {
            // Serve
            Console.WriteLine($"Wuhu the pizza is done. Enjoy your {myPizza.Name}. With {myPizza.Toppings[0]}!");
        }
    }
}
