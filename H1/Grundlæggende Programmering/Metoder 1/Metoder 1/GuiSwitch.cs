using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_1
{
    class GuiSwitch
    {

        public static void MainMenuSwitch(string mainMenu)
        {
            switch (mainMenu)
            {
                case "0":
                    break;
                case "1":
                    Gui.Opg1();
                    break;
                case "2":
                    Gui.Opg2();
                    break;
                case "3":
                    Gui.Opg3();
                    break;
                case "4":
                    Gui.Opg4();
                    break;
                case "5":
                    Gui.Opg5();
                    break;
                case "6":
                    Gui.Opg6();
                    break;
                case "7":
                    Gui.Opg7();
                    break;
                case "8":
                    Gui.Opg8();
                    break;
                case "9":
                    Gui.Opg9();
                    break;
                case "10":
                    Gui.Opg10();
                    break;

            }
        }

        public static double Opg1GuiSwitch(char mainMenu, double firstNumber, double secondNumber)
        {

            switch (mainMenu)
            {
                case '1':
                    return Logic.Addition(firstNumber, secondNumber);
                case '2':
                    return Logic.Divided(firstNumber, secondNumber);
                case '3':
                    return Logic.Moduls(firstNumber, secondNumber);
                case '4':
                    return Logic.Potency(firstNumber, secondNumber);
                default:
                    return -1;

            }
        }

        public static string Opg2GuiSwitch(char mainMenu, double firstNumber, double secondNumber)
        {

            switch (mainMenu)
            {
                case '1':
                    return Logic.Hypotenuse(firstNumber, secondNumber);
                case '2':
                    return Logic.WhatBiggest(firstNumber, secondNumber);
                default:
                    return "Error";
            }
        }

        public static string Opg3GuiSwitch(string userName, double userAge)
        {

            return Logic.WhatCanUserDo(userAge, userName);
        }

        public static string Opg4GuiSwitch()
        {
            return Logic.GetNumbersAscending();
        }
        public static string Opg5GuiSwitch()
        {
            return Logic.GetNumbersDescending();
        }
        public static string Opg6GuiSwitch(int firstNumber)
        {
            return Logic.GetNumbers(firstNumber);
        }
        public static string Opg7GuiSwitch()
        {
            return Logic.ArrayWith9Elements();
        }
        public static string Opg8GuiSwitch()
        {
            return Logic.ListWith20Elements();
        }
        public static string Opg9GuiSwitch()
        {
            return Logic.Lotto();
        }
        public static string Opg10GuiSwitch()
        {
            return Logic.GuessANumber();
        }
    }
}
