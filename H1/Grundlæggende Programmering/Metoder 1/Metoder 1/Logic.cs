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

    }
}
