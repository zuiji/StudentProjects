using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        private string color;
        private int weel;
        private int door;
        private int year;
        private string type;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public int Weel
        {
            get { return weel; }
            set { weel = value; }
        }


        public int Door
        {
            get { return door; }
            set { door = value; }
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Car()
        {
            List.add(this>myCar)
        }


        public Car(string color, int weel, int door, int year, string type)
        {
            color = Color;
            weel = Weel;
            door = Door;
            year = Year;
            type = Type;
            //list.add(this>)
        }

        public List<Car> myList = new List<Car>();
        
    }

}
