using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
   public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("welcome to my application");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }
    }
}
