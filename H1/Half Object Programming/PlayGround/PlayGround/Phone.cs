using System;

namespace PlayGround
{
    public class Phone
    {
        public string PhoneNumber { get; set; }

        public static string Model { get; set; }

        public Phone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;

        }

        public void PrintPhoneNumber()
        {
            Console.WriteLine(PhoneNumber);

        }

        public void PrintPhoneModel()
        {
            Console.WriteLine(Model);
        }

        //statik kan kun tilgå andre statisk ting

        //alt kan tilgå statisk ting

        //statisk ting tilgår man på class 
        //og ikke statisk ting tilgår man på object Nevrue

        // public tilgåes over alt
        // private kan kun tilgåes i classen


    }
}