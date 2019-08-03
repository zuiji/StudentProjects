using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static double result;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Simple Calculator");
            Console.WriteLine("Insert your first number");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert what you want to do with your numbers.\nYour options is / * - + ");
            char calculationMethod = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Insert your Second Number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());


            if (calculationMethod == '+')
            {
                AddTogther(firstNumber, secondNumber);
                Console.WriteLine($"The Result is {result}");
            }
            else if (calculationMethod == '-')
            {
                minus(firstNumber, secondNumber);
                Console.WriteLine($"The Result is {result}");
            }
            else if (calculationMethod == '*')
            {
                multiply(firstNumber, secondNumber);
                Console.WriteLine($"The Result is {result}");
            }
            else if (calculationMethod == '/')
            {
                if (secondNumber != 0)
                {
                    dividing(firstNumber, secondNumber);
                    Console.WriteLine($"The Result is {result}");
                }
                else
                {
                    Console.WriteLine("Div/Zero");
                }
            }

        }

        static double AddTogther(double firstNumber, double secondNumber)
        {
            result = firstNumber + secondNumber;
            return result;

        }
        static double minus(double firstNumber, double secondNumber)
        {
            result = firstNumber - secondNumber;
            return result;

        }
        static double multiply(double firstNumber, double secondNumber)
        {
            result = firstNumber * secondNumber;
            return result;

        }
        static double dividing(double firstNumber, double secondNumber)
        {
            result = firstNumber / secondNumber;
            return result;

        }

    }


}
