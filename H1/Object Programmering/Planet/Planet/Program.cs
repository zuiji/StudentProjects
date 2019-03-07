﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            //Making a list of all planets and writing to console
            List<string> planet = new List<string>();
            planet.Add(new Planet("Mercury", 0.333, 4879, 5472, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false));
            planet.Add(new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false));
            planet.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false));
            planet.Add(new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true));
            planet.Add(new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true));
            planet.Add(new Planet("Uranus", 86.8, 52118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true));
            planet.Add(new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 60189, 5.4, -200, 14, true));
            planet.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90560, 4.7, -225, 5, false));

            //running it truth an foreach loop
            foreach (Planet item in planet)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("");

            //inserting venus

            planet.Insert(1, new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false));

            foreach (Planet item in planet)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("");

            //Searching for pluto, Getting the index number and removing it.
            foreach (Planet item in planet)
            {
                if (item.Name == "Pluto")
                {
                    index = planet.IndexOf(item);
                    Console.WriteLine("Removing item at index: {0}", index);
                }
            }

            Console.WriteLine("");
            planet.RemoveAt(index);
            foreach (Planet item in planet)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("");

            // Adding Pluto again

            planet.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90560, 4.7, -225, 5, false));

            // Getting the number of elements in the List
            Console.WriteLine("Number of Planets in the List = {0}", planet.Count);
            Console.WriteLine("");
            // Getting the elements in the List with "MeanTemperature" < 0
            foreach (Planet item in planet)
            {
                if (item.MeanTemperature < 0)
                {
                    Console.WriteLine("Planet name : {0} \r\nPlanet mean Temp: {1}", item.Name, item.MeanTemperature);
                }
            }

            Console.WriteLine("");

            // Getting Planets with diameter between 10000km - 50000km

            foreach (Planet item in planet)
            {
                if (item.Diamenter > 10000 && item.Diamenter < 50000)
                {
                    Console.WriteLine("Planet name : {0} \r\nPlanet diamenter: {1}km", item.Name, item.Diamenter);
                }
            }

            Console.WriteLine("");
            //removing all elements
            planet.Clear();
            Console.ReadKey();
        }
    }
}
