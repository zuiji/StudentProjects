using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public static string GetNumbersAscending()
        {
            string Numbers = "";
            for (int i = 1; i < 11; i++)
            {
                Numbers += i + " ";
            }

            return Numbers;
        }

        public static string GetNumbersDescending()
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

        public static string ArrayWith9Elements()
        {
            int[] array1 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                array1[i] = i + 1;
            }

            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                {
                    array1[i] = array1[i] * 2;
                }

            }

            string Numbers = "";
            for (int i = 0; i < 9; i++)
            {
                Numbers += array1[i] + " ";
            }

            return Numbers;

        }

        public static string ListWith20Elements()
        {
            string Numbers = "";

            List<int> listeB = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                listeB.Add(i);
            }

            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    listeB.Remove(i);
                }


            }

            Numbers += $"listeB indeholder efter vi har fjernet alle tal som går op i 3 {listeB.Count} elementer\n\n";

            listeB.Insert(2, 17);

            List<int> listeC = new List<int>();
            for (int i = 0; i < listeB.Count; i++)
            {
                listeC.Add(listeB[i]);
            }

            listeC.Reverse();
            Numbers += "listeB: ";
            for (int i = 0; i < listeB.Count; i++)
            {
                Numbers += listeB[i] + " ";
            }

            Numbers += "\n";
            Numbers += "listeC: ";
            for (int i = 0; i < listeC.Count; i++)
            {
                Numbers += listeC[i] + " ";
            }

            return Numbers;
        }

        public static string Lotto()
        {
            string Numbers = "";
            int[] lottoArray = new int[7];
            int[] kuponArray = new int[7];
            Random r = new Random();

            for (int i = 0; i < lottoArray.Length; i++)
            {
                int ran = r.Next(1, 20);
                lottoArray[i] = ran;

            }

            for (int i = 0; i < lottoArray.Length; i++)
            {
                for (int j = 0; j < lottoArray.Length - 1; j++)
                {
                    if (lottoArray[j] < lottoArray[j + 1])
                    {
                        continue;
                    }

                    int temp = lottoArray[j];
                    lottoArray[j] = lottoArray[j + 1];
                    lottoArray[j + 1] = temp;
                }
            }

            for (int i = 0; i < kuponArray.Length; i++)
            {
                int ran = r.Next(1, 20);
                kuponArray[i] = ran;

            }

            for (int i = 0; i < kuponArray.Length; i++)
            {
                for (int j = 0; j < kuponArray.Length - 1; j++)
                {
                    if (kuponArray[j] < kuponArray[j + 1])
                    { }
                    else
                    {
                        int temp1 = kuponArray[j];
                        kuponArray[j] = kuponArray[j + 1];
                        kuponArray[j + 1] = temp1;
                    }
                }
            }

            Numbers += "The lotto numbers that was drawn is: ";
            foreach (int int32 in lottoArray)
            {
                Numbers += int32 + " ";
            }

            Numbers += "\n";

            Numbers += "Your kupon numbers is: ";
            foreach (int int32 in kuponArray)
            {
                Numbers += int32 + " ";
            }

            int correctNumbers = 0;
            foreach (int k in kuponArray)
            {
                foreach (int l in lottoArray)
                {
                    if (k == l)
                    {
                        correctNumbers++;
                        break;
                    }
                }
            }

            Numbers += "\n";
            int prize = 0;
            switch (correctNumbers)
            {
                case 3:
                    prize = 125;
                    break;
                case 4:
                    prize = 250;
                    break;
                case 5:
                    prize = 1250;
                    break;
                case 6:
                    prize = 22500;
                    break;
                case 7:
                    prize = 6000000;
                    break;
                default:
                    Numbers +="To bad you did not win anything, Try again next week.\n";
                    break;
            }

            if (prize > 0)
            {
                Numbers += $"Hurray you did win {prize}kr.\n";
            }

            return Numbers;
        }

        public static string GuessANumber()
        {
            string Numbers = "";
            int inputFromUser;
            int tryFromUser = 1;
            do
            {

                Numbers += "\nHere you need to guess a number between 1 and 10\n";
                Random random = new Random();
                int RollOfTheDice = random.Next(1, 10);

                inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(false).KeyChar));
                while (inputFromUser != RollOfTheDice)
                {

                    if (RollOfTheDice < inputFromUser)
                    {
                        Numbers += " Sorry.. But your guess was wrong. try with a lower number\n";
                    }
                    else if (RollOfTheDice > inputFromUser)
                    {
                        Numbers += " Sorry.. But your guess was wrong. try with a higher number\n";
                    }

                    inputFromUser = Convert.ToInt32(Convert.ToString(Console.ReadKey(false).KeyChar));
                    tryFromUser++;
                }

                Numbers += " Hurra..! you did guess the number\n You used " + tryFromUser + " guess";


                tryFromUser++;
            } while (false);

            return Numbers;
        }
    }
}
