using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Person perObj = new Person();

           perObj.name = "Per";

           perObj.Age = 12;
           Console.WriteLine(perObj.Age);




           Person p1 = new Person("Bo",5);
           string res =  perObj.Sleep(12);

          Console.WriteLine(res);

            
        }
    }
}
