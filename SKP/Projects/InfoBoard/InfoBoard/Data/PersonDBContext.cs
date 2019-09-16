using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoBoard.Models;

namespace InfoBoard.Data
{
    public static class PersonDbContext
    {
        public static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person()
            {
                FirstName = "Anders",
                MiddleName = "Thomhav",
                LastName = "Stubberup",
                PhoneNumber = "88888888",
                Email = "Anders@anders.dk",
                Watches = new Dictionary<string, char>()
                {
                    { new DateTime(2019,9,1).ToShortDateString(),'x'},
                    { new DateTime(2019,9,2).ToShortDateString(),'x'},
                    { new DateTime(2019,9,3).ToShortDateString(),'x'}, 
                    { new DateTime(2019,9,4).ToShortDateString(),'x'},
                    { new DateTime(2019,9,5).ToShortDateString(),'x'},
                    { new DateTime(2019,9,6).ToShortDateString(),'r'},
                    { new DateTime(2019,9,7).ToShortDateString(),'r'},
                    { new DateTime(2019,9,8).ToShortDateString(),'r'},
                    { new DateTime(2019,9,9).ToShortDateString(),'r'},
                    { new DateTime(2019,9,10).ToShortDateString(),'r'},
                    { new DateTime(2019,9,21).ToShortDateString(),'n'},
                    { new DateTime(2019,9,22).ToShortDateString(),'n'},
                    { new DateTime(2019,9,23).ToShortDateString(),'n'},
                    { new DateTime(2019,9,24).ToShortDateString(),'n'},
                    { new DateTime(2019,9,25).ToShortDateString(),'n'},
                    { new DateTime(2019,9,26).ToShortDateString(),'x'},
                    { new DateTime(2019,9,27).ToShortDateString(),'x'},
                    { new DateTime(2019,9,28).ToShortDateString(),'x'},
                    { new DateTime(2019,9,29).ToShortDateString(),'x'},
                    { new DateTime(2019,9,30).ToShortDateString(),'x'},

                }



            });
            persons.Add(new Person()
            {
                FirstName = "Andreas",
                MiddleName = "torskmon",
                LastName = "petersen",
                PhoneNumber = "88888888",
                Email = "hahan@ders.dk",
                Watches = new Dictionary<string, char>()
                {
                    { new DateTime(2019,9,1).ToShortDateString(),'n'},
                    { new DateTime(2019,9,2).ToShortDateString(),'n'},
                    { new DateTime(2019,9,3).ToShortDateString(),'n'},
                    { new DateTime(2019,9,4).ToShortDateString(),'n'},
                    { new DateTime(2019,9,5).ToShortDateString(),'n'},
                    { new DateTime(2019,9,6).ToShortDateString(),'x'},
                    { new DateTime(2019,9,7).ToShortDateString(),'x'},
                    { new DateTime(2019,9,8).ToShortDateString(),'x'},
                    { new DateTime(2019,9,9).ToShortDateString(),'x'},
                    { new DateTime(2019,9,10).ToShortDateString(),'r'},
                    { new DateTime(2019,9,11).ToShortDateString(),'r'},
                    { new DateTime(2019,9,22).ToShortDateString(),'r'},
                    { new DateTime(2019,9,13).ToShortDateString(),'r'},
                    { new DateTime(2019,9,14).ToShortDateString(),'r'},
                    { new DateTime(2019,9,15).ToShortDateString(),'r'},


                }


            }); persons.Add(new Person()
            {
                FirstName = "ann",
                MiddleName = "",
                LastName = "Stubberup",
                PhoneNumber = "88888888",
                Email = "and@and.dk",
                Watches = new Dictionary<string, char>()
                {
                    { new DateTime(2019,9,6).ToShortDateString(),'n'},
                    { new DateTime(2019,9,7).ToShortDateString(),'n'},
                    { new DateTime(2019,9,8).ToShortDateString(),'n'},
                    { new DateTime(2019,9,9).ToShortDateString(),'n'},
                    { new DateTime(2019,9,10).ToShortDateString(),'n'},
                    { new DateTime(2019,9,11).ToShortDateString(),'x'},
                    { new DateTime(2019,9,22).ToShortDateString(),'x'},
                    { new DateTime(2019,9,13).ToShortDateString(),'x'},
                    { new DateTime(2019,9,14).ToShortDateString(),'x'},
                    { new DateTime(2019,9,15).ToShortDateString(),'x'},
                    { new DateTime(2019,9,16).ToShortDateString(),'r'},
                    { new DateTime(2019,9,17).ToShortDateString(),'r'},
                    { new DateTime(2019,9,18).ToShortDateString(),'r'},
                    { new DateTime(2019,9,19).ToShortDateString(),'r'},
                    { new DateTime(2019,9,20).ToShortDateString(),'r'},

                }


            }); persons.Add(new Person()
            {
                FirstName = "peter",
                MiddleName = "Bøgh",
                LastName = "Stubberup",
                PhoneNumber = "88888888",
                Email = "pbs@shadesofchaos.dk",
                Watches = new Dictionary<string, char>()
                {
                    { new DateTime(2019,9,11).ToShortDateString(),'n'},
                    { new DateTime(2019,9,12).ToShortDateString(),'n'},
                    { new DateTime(2019,9,13).ToShortDateString(),'n'},
                    { new DateTime(2019,9,14).ToShortDateString(),'n'},
                    { new DateTime(2019,9,15).ToShortDateString(),'n'},
                    { new DateTime(2019,9,16).ToShortDateString(),'x'},
                    { new DateTime(2019,9,17).ToShortDateString(),'x'},
                    { new DateTime(2019,9,18).ToShortDateString(),'x'},
                    { new DateTime(2019,9,19).ToShortDateString(),'x'},
                    { new DateTime(2019,9,20).ToShortDateString(),'x'},
                    { new DateTime(2019,9,21).ToShortDateString(),'r'},
                    { new DateTime(2019,9,22).ToShortDateString(),'r'},
                    { new DateTime(2019,9,23).ToShortDateString(),'r'},
                    { new DateTime(2019,9,24).ToShortDateString(),'r'},
                    { new DateTime(2019,9,25).ToShortDateString(),'r'},

                }


            }); persons.Add(new Person()
            {
                FirstName = "mad",
                MiddleName = "",
                LastName = "Soup",
                PhoneNumber = "88888888",
                Email = "jads@hajd.dk",
                Watches = new Dictionary<string, char>()
                {   { new DateTime(2019,9,16).ToShortDateString(),'n'},
                    { new DateTime(2019,9,17).ToShortDateString(),'n'},
                    { new DateTime(2019,9,18).ToShortDateString(),'n'},
                    { new DateTime(2019,9,19).ToShortDateString(),'n'},
                    { new DateTime(2019,9,20).ToShortDateString(),'n'},
                    { new DateTime(2019,9,21).ToShortDateString(),'x'},
                    { new DateTime(2019,9,22).ToShortDateString(),'x'},
                    { new DateTime(2019,9,23).ToShortDateString(),'x'},
                    { new DateTime(2019,9,24).ToShortDateString(),'x'},
                    { new DateTime(2019,9,25).ToShortDateString(),'x'},
                    { new DateTime(2019,9,26).ToShortDateString(),'r'},
                    { new DateTime(2019,9,27).ToShortDateString(),'r'},
                    { new DateTime(2019,9,28).ToShortDateString(),'r'},
                    { new DateTime(2019,9,29).ToShortDateString(),'r'},
                    { new DateTime(2019,9,30).ToShortDateString(),'r'},

                }


            });


            return null;
        }
    }
}
