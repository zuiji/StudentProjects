using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_opgave_2
{
    class Solution
    {

        static int simpleArraySum(int n, int[] ar)
        {
            int sum = 0;
            // Complete this function
            for (int i = 0; i < n; i++)
            {

                sum += ar[i];

            }

            return sum;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}