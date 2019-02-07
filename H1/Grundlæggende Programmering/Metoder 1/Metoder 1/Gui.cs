using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Metoder_1
{
    class Gui
    {
        public static void Main()
        {

            Gui.Clear();

            Console.WriteLine("{ Main menu }\n");
            Console.WriteLine("{ 0 }\t Exit");
            Console.WriteLine("{ 1 }\t Opg 1");
            Console.WriteLine("{ 2 }\t Opg 2");
            Console.WriteLine("{ 3 }\t Opg 3");
            Console.WriteLine("{ 4 }\t Opg 4");
            Console.WriteLine("{ 5 }\t Opg 5");
            Console.WriteLine("{ 6 }\t Opg 6");
            Console.WriteLine("{ 7 }\t Opg 7");
            Console.WriteLine("{ 8 }\t Opg 8");
            Console.WriteLine("{ 9 }\t Opg 9");
            Console.WriteLine("{ 10 } Opg 10");
            Console.WriteLine("{ 11 } ToDo");

            string mainMenu = Console.ReadLine();
            Clear();
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
            char mainMenu = Console.ReadKey(true).KeyChar;
            Console.WriteLine(GuiSwitch.Opg3GuiSwitch(userName, userAge));


        }

        public static void Opg4()
        {
            Clear();
            Console.WriteLine(GuiSwitch.Opg4GuiSwitch());
        }
        public static void Opg5()
        {
            Clear();
            Console.WriteLine(GuiSwitch.Opg5GuiSwitch());
        }
        public static void Opg6()
        {
            Clear();
            Console.WriteLine("Please enter a number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GuiSwitch.Opg6GuiSwitch(firstNumber));
        }

        public static void Opg7()
        {
            Clear();
            Console.WriteLine(GuiSwitch.Opg7GuiSwitch());
        }

        public static void Opg8()
        {
            Clear();
            Console.WriteLine(GuiSwitch.Opg8GuiSwitch());
        }
        public static void Opg9()
        {
            Clear();
            Console.WriteLine(GuiSwitch.Opg9GuiSwitch());
        }
        public static void Opg10()
        {
            Clear();
            Console.WriteLine(GuiSwitch.Opg10GuiSwitch());
        }
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
