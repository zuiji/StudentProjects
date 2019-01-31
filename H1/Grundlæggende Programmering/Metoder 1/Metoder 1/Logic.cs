using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_1
{
    class Logic
    {
        public static double Addition(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;

        }

        public static double Divided(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;

        }

        public static double Moduls(double firstNumber, double secondNumber)
        {
            double result = firstNumber % secondNumber;
            return result;

        }

        public static double Potency(double firstNumber, double secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }

        public static double Hypotenuse(double firstNumber, double secondNumber)
        {
            double result = Math.Sqrt((firstNumber * firstNumber) + (secondNumber * secondNumber));
            return result;
        }

        public static double WhatBiggest(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else if (firstNumber < secondNumber)
            {
                return secondNumber;
            }
            else if (firstNumber == secondNumber)
            {
                return -1;
            }
            return -1;

        }

        public static string WhatCanUserDo(double userAge, String printNumber)
        {
            if (userAge <=3)
            {
                return "1";
            }
            else if (userAge >= 4 && userAge <= 15)
            {
                return "2";
            }
            else if (userAge >= 15 && userAge <18)
            {
                return "3";
            }
            else if (userAge >= 18)
            {
                return "4";
            }

            return printNumber;

        }
    }
}
