using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        #region Variables
        private string name;
        private int age;
        private int zipCode;
        private string city;
        private int phoneNumber;
        private string email;
        #endregion

        #region Proberty
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        public Person()
        {

        }
        public Person(string name, int age, int zipCode, string city, int phoneNumber, string email)
        {
            Name = name;
            Age = age;
            ZipCode = zipCode;
            City = city;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        
    }
}
