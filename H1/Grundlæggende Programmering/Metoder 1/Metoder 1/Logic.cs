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

        public static string Hypotenuse(double firstNumber, double secondNumber)
        {
            double result = Math.Sqrt((firstNumber * firstNumber) + (secondNumber * secondNumber));
            return result.ToString();
        }

        public static string WhatBiggest(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber.ToString();
            }
            else if (firstNumber < secondNumber)
            {
                return secondNumber.ToString();
            }
            else
            {
                return "same size";
            }


        }

        public static string WhatCanUserDo(double userAge, string userName)
        {
            if (userAge <= 3)
            {
                return $"{userName}, du må gå med ble";
            }
            else if (userAge <= 15)
            {
                return $"{userName}, du må ingenting";
            }
            else if (userAge < 18)
            {
                return $"{userName},du må drikke";
            }
            else
            {
                return $"{userName}, du må stemme og køre bil";
            }


        }

        public static string GetNumbersAcending()
        {
            string Numbers = "";
            for (int i = 1; i < 11; i++)
            {
                Numbers += i + " ";
            }

            return Numbers;
        }
        public static string GetNumbersDecending()
        {
            string Numbers = "";
            for (int i = 10; i > 0; i--)
            {
                Numbers += i + " ";
            }

            return Numbers;
        }
        public static string GetNumbers(int firstNumber)
        {
            string Numbers = "";
            for (int i = firstNumber + 32; i < 297; i++)
            {
                Numbers += i + " ";
            }

            return Numbers;
        }
    }
}
