using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputFromUser = '0';
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("lets Calculate your BMI.");
                Console.WriteLine("How high are you?");
                double high = double.Parse(Console.ReadLine());
                high /= 100;
                Console.WriteLine("What is your Wight?");
                double wight = double.Parse(Console.ReadLine());
                double BMI = (wight / (high * high));
                if (BMI < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your BMi is: {BMI} and you wight to less");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("do you want to calculate another BMI Press { 1 }");
                    inputFromUser = Console.ReadKey(true).KeyChar;
                }

                else if (BMI < 24.9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your BMi is: {BMI} and your wight is normal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("do you want to calculate another BMI Press { 1 }");
                    inputFromUser = Console.ReadKey(true).KeyChar;
                }

                else if (BMI < 29.9)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Your BMi is: {BMI} and you wight to much");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("do you want to calculate another BMI Press { 1 }");
                    inputFromUser = Console.ReadKey(true).KeyChar;
                }
                else if (BMI < 34.9)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Your BMi is: {BMI} and you are now in Class 1 for over wight");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("do you want to calculate another BMI Press { 1 }");
                    inputFromUser = Console.ReadKey(true).KeyChar;
                }
                else if (BMI < 39.9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your BMi is: {BMI} and you are now in Class 2 for over wight");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("do you want to calculate another BMI Press { 1 }");
                    inputFromUser = Console.ReadKey(true).KeyChar;
                }
                else if (BMI > 40.0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Your BMi is: {BMI} and you are now in Class 3 for over wight");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("do you want to calculate another BMI Press { 1 }");
                    inputFromUser = Console.ReadKey(true).KeyChar;
                }
            } while (inputFromUser == '1');
        }
    }
}
