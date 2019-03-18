using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("");


        }

        public void AddObject()
        {
            //Object 
            Car myCar = new Car();
            //object info
            myCar.Color = "Red";

            //Object
            Car b = new Car();
            //object info
            b.Type = "VW";

            //object
            Car c = new Car();

            //object info
            c.Door = 5;
            c.Weel = 4;
            c.Year = 2008;
        }
    }
}
