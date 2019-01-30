using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_1
{
    class GuiSwitch
    {
        public static void FirstSwitch()
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
                    break;
                
            }
        }

        public static void SecondSwitch()
        {

        }
    }
}
