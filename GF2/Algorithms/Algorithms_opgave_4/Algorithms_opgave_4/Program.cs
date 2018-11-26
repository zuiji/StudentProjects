using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_opgave_4
{
    class Solution
    {

        static int diagonalDifference(int[][] a)
        {
            // Complete this function
            int j = 0;
            int k = 0;
            for (int i = 0; i < a.Length; i++)
           
            {
                j += a[i][i];

                k += a[a.Length  -1 -i][i];
                
            }

            return Math.Abs(j-k);
        }


        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int result = diagonalDifference(a);
            Console.WriteLine(result);
        }

    }
}
