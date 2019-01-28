using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    array1[i] = i * 2;

                }
                else
                {
                    array1[i] = i;
                }
                Console.WriteLine(array1[i]);
            }
        }
    }
}
