using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoBoard.Models
{
    public class Person
    {
        public string FirstName {get; set;}
        public string MiddleName { get; set; }
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}

        public Dictionary<string,char> Watches {get; set;}

        public char GetWatchesForDay(DateTime date)
        {
            if (Watches.ContainsKey(date.ToShortDateString()))
            {
                return Watches[date.ToShortDateString()];
            }
            return '\0';
        }



    }
}
