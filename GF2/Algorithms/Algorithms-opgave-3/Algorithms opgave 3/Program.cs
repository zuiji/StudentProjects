using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_opgave_3
{
    class Solution
    {

        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            // Complete this function
            int a = 0;
            int b = 0;

            if (a0 > b0)
            {
                a = a +1;
            }
            else if (a0 < b0)
            {
                b = b + 1;
            }
            if (a1 > b1)
            {
                a = a + 1;
            }
           else if (a1 < b1)
            {
                b = b + 1;
            }
            if (a2 > b2)
            {
                a = a + 1;
            }
            else if (a2 < b2)
            {
                b = b + 1;
            }

            return new int[2] {a, b};
        }

        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}
