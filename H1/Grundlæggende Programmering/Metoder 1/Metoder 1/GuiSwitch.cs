using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_1
{
    class GuiSwitch
    {
        
        public static void MainMenuSwitch()
        {   Gui.Clear();

            Console.WriteLine("{ Main menu }\n");
            Console.WriteLine("{ 1 } Opg 1");
            Console.WriteLine("{ 0 } Exit");
            char MainMenu = Console.ReadKey().KeyChar;
            switch (MainMenu)
            {
                case '0':
                    
                    break;
                    
                case '1':
                    Opg1();
                    break;
                
            }
        }

        public static void Opg1()
        {
            Gui.Clear();
            Console.WriteLine("{ Opg1 }\n");
            Console.WriteLine("{ 1 } Addition");
            Console.WriteLine("{ 2 } Dividing");
            Console.WriteLine("{ 3 } Modulus");
            Console.WriteLine("{ 0 } Return to Main menu");
            char MainMenu = Console.ReadKey().KeyChar;
            switch (MainMenu)
            {
                case '1':
                    Logic.Addition();
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                default:
                    break;
            }

        }
    }
}
