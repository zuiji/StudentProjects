using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTest
{
    class Person
    {
        public string name;
        private int age;

        #region propertise

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        } 
        #endregion

        public Person()
        {
            
        }

        public Person(string name, int age)
        {
            this.name = name;

            this.age = age;

        }
        public void Eat()
        {
            Console.WriteLine("eat... mums");
        }

        public string Sleep(int time)
        {
            return "ZZZzzzZZZ";
        }


    }
}
