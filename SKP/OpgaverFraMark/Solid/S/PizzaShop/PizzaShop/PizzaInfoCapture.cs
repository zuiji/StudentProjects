using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    public class PizzaInfoCapture
    {
        public  Pizza Capture()
        {
            Pizza myPizzaOutput = new Pizza();
            // Give your pizza a unique name
            Console.WriteLine("Give your pizza a unique name:");
            myPizzaOutput.Name = Console.ReadLine();
            
            return myPizzaOutput;
        }

        public List<Pizza> Topping()
        {
            List<Pizza> tempTopList = new List<Pizza>();
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
            tempTopList.Add(tempTop);

            return tempTopList;
        }
    }
}
