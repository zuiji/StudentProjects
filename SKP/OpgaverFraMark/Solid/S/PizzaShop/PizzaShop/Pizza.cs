using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
   public class Pizza
    {
        public string Name { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza()
        {
            Toppings = new List<string>();
        }
    }
}
