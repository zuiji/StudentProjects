using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer machine = new Washer();
            while (true)
            {
                char inputFormUser = Console.ReadKey(true).KeyChar;
                switch (inputFormUser)
                {
                    case '1':
                        machine.Fill();
                        break;
                    case '2':
                        machine.PowerOnOff();
                        break;
                    case '3':
                        machine.OpenClose();
                        break;
                    case '4':
                        machine.Spin();
                        break;
                    case '5':
                        machine.Wash(false);
                        break;

                }

            }
            
        
            
           
            Console.ReadKey();

        }
    }
}
