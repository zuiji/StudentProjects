using System;
using System.Runtime.InteropServices;

namespace Metoder_1
{
    class Gui
    {
        public static void Main()
        {
            Gui.Clear();

            Console.WriteLine("{ Main menu }\n");
            Console.WriteLine("{ 0 } Exit");
            Console.WriteLine("{ 1 } Opg 1");
            Console.WriteLine("{ 2 } Opg 2");
            Console.WriteLine("{ 3 } ToDo");
            Console.WriteLine("{ 4 } ToDo");
            Console.WriteLine("{ 5 } ToDo");
            Console.WriteLine("{ 6 } ToDo");
            Console.WriteLine("{ 7 } ToDo");
            Console.WriteLine("{ 8 } ToDo");
            Console.WriteLine("{ 9 } ToDo");
            Console.WriteLine("{ 10 } ToDo");
            Console.WriteLine("{ 11 } ToDo");
            
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
            Console.WriteLine("{ Opg1GuiSwitch }\n");
            Console.WriteLine("{ 1 } Addition");
            Console.WriteLine("{ 2 } Dividing");
            Console.WriteLine("{ 3 } Modulus");
            Console.WriteLine("{ 4 } potency");
            Console.WriteLine("{ 0 } Return to Main menu");
            char mainMenu = Console.ReadKey(true).KeyChar;
            Console.WriteLine(GuiSwitch.Opg1GuiSwitch(mainMenu, firstNumber, secondNumber));

        }

        public static void Opg2()
        {
            Clear();
            Console.WriteLine("Please enter a number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            double secondNumber = double.Parse(Console.ReadLine());
            Clear();
            Console.WriteLine("{ Opg2GuiSwitch }\n");
            Console.WriteLine("{ 1 } Hypotenuse");
            Console.WriteLine("{ 2 } WhatBiggest");
            char mainMenu = Console.ReadKey(true).KeyChar;
            Console.WriteLine(GuiSwitch.Opg2GuiSwitch(mainMenu, firstNumber, secondNumber));
        }

        public static void Opg3()
        {
            Clear();
            Console.WriteLine("Please enter your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your Age");
            double userAge = double.Parse(Console.ReadLine());

            string[] printNumber = new string[5];
                
            char mainMenu = Console.ReadKey(true).KeyChar;
            Console.WriteLine(GuiSwitch.Opg3GuiSwitch(mainMenu, userName, userAge, ));
            
        }

        public static void Clear()
        {
            Console.Clear();
        }
    }
}
