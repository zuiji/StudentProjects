using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_1
{
    class Gui
    {
        public static void Main()
        {
            Gui.Clear();

            Console.WriteLine("{ Main menu }\n");
            Console.WriteLine("{ 1 } Opg 1");
            Console.WriteLine("{ 0 } Exit");
            char mainMenu = Console.ReadKey(true).KeyChar;
            GuiSwitch.MainMenuSwitch(mainMenu);
            }

        public static void Opg1()
        {
            Gui.Clear();
            Console.WriteLine("Please enter a number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            double secondNumber = double.Parse(Console.ReadLine());
            Gui.Clear();
            Console.WriteLine("{ Opg1 }\n");
            Console.WriteLine("{ 1 } Addition");
            Console.WriteLine("{ 2 } Dividing");
            Console.WriteLine("{ 3 } Modulus");
            Console.WriteLine("{ 4 } toBeContenued");
            Console.WriteLine("{ 0 } Return to Main menu");
            char mainMenu = Console.ReadKey(true).KeyChar;
            Console.WriteLine(GuiSwitch.Opg1(mainMenu, firstNumber, secondNumber));

        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
