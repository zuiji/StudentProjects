using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom___CRP_check
{
    class inputFromUser
    {
        public static void
            
            RuninputFromUser()
        {
            char inputFormUser;
           
            do
            {
                Console.WriteLine("Hello "+ System.Environment.UserName +"\nWelcome to my Palindrom and CPR checker.\nin this program you will be able to check our CPR if you are a Girl or Boy.\nWhen you can go on retirement.\n\nin the Palindrom part you will be able to see,\nif your word is a Palindrom\nif your word are spelled exatly the same forward and backward.");
                Console.WriteLine("Please press 1 for Palindrom, 2 for CPR Check or 3 to stop");
                inputFormUser = Console.ReadKey(true).KeyChar;
                Clear.RunClear();
                switch (inputFormUser)
                {
                    case '1':
                        palindrom.Palindrom();
                        Clear.RunClear();
                        break;
                    case '2':
                        CPRCheck.RunCPRCheck();
                        Clear.RunClear();
                        break;
                    case '3':
                        
                        break;
                    default: Console.WriteLine("Please pick 1, 2 or 3");
                        
                        break;
                }

            } while (inputFormUser!='3');
        }

       
    }
}
