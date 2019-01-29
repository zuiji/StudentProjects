using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lottoArray = new int[7];
            int[] kuponArray = new int[7];
            Random r = new Random();
            
            for (int i = 0; i < lottoArray.Length; i++)
            {
                int ran = r.Next(1, 20);
                lottoArray[i] = ran;
                //Console.WriteLine(ran);
            }

            for (int i = 0; i < lottoArray.Length; i++)
            {
                for (int j = 0; j < (lottoArray.Length-1); j++)
                {
                    if (lottoArray[j] < lottoArray[j + 1] )
                        continue;
                    else
                    {
                        int temp = lottoArray[j];
                        lottoArray[j] = lottoArray[j + 1];
                        lottoArray[j + 1] = temp;
                        
                    }
                }
            }
            for (int i = 0; i < kuponArray.Length; i++)
            {
                int ran = r.Next(1, 20);
                kuponArray[i] = ran;
                //Console.WriteLine(ran);
            }

            for (int i = 0; i < kuponArray.Length; i++)
            {
                for (int j = 0; j < (kuponArray.Length - 1); j++)
                {
                    if (kuponArray[j] < kuponArray[j + 1])
                        continue;
                    else
                    {
                        int temp1 = kuponArray[j];
                        kuponArray[j] = kuponArray[j + 1];
                        kuponArray[j + 1] = temp1;

                    }
                }
            }

            if ()
            {
                Console.WriteLine("Hurra you did win");
            }
            foreach (int int32 in lottoArray)
            {
                System.Console.WriteLine("The lotto numbers that was drown is " + int32);
            }

            Console.WriteLine();

            foreach (int int32 in kuponArray)
            {
                System.Console.WriteLine("your kupon numbers is " + int32);
            }

        }
    }
}
