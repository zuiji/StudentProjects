using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class PizzaNameCapture
    {
        public static Pizza Capture()
        {
            Pizza myPizzaOutput = new Pizza();
            // Give your pizza a unique name
            Console.WriteLine("Give your pizza a unique name:");
            myPizzaOutput.Name = Console.ReadLine();
            
            return myPizzaOutput;
        }
    }
}
