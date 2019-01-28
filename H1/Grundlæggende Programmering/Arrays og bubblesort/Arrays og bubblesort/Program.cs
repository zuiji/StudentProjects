using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_og_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[100];

            //opret det objekt der er tilfældighedsgenerator
            Random random = new Random();


            for (int i = 0; i < tal.Length; i++)
            {
                //randonNumber indeholder nu et tilfældigt tal mellem 0-1000
                int randomNumber = random.Next(0, 1000);
                //Her skal der indsættes tilfældige tal
                //for alle elementer i arrayet
                tal[i] = randomNumber;
                //  Console.WriteLine(tal[i]);

                for (int j = 0; j < (tal.Length-1) - i; j++)
                {
                    //Her skal der indsættes tilfældige tal
                    //for alle elementer i arrayet
                    if (tal[j] > tal[j + 1])
                    {
                        int temp = tal[j + 1];
                        tal[j + 1] = tal[j];
                        tal[j] = temp;
                        

                    }
                }
            }
        }
    }
}
