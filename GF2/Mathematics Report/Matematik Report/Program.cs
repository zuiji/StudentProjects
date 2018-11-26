using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_Report
{
    class Program
    {
        static void Main(string[] args)
        {

            string svar;
            do
            {
                /*
                Welcome text.
                */
                Console.WriteLine("Hej Velkommen til min Matematik Report.");
                Console.WriteLine("Skrevet og kodet af");
                Console.WriteLine("Peter Bøgh Stubberup\n");


                /*
                explanes the user what we can do in this Program.
                in this case i have maked a program there the user should be able to calculate the Area, volume and density.
                and you should be able to calculate them for Threesomes,squares,polygons and circles
                */
                Console.WriteLine("I denne opgave kan du udregne arealet, rumfanget og diameteren af en Firkant, Trekant og en Cirkel.");
                Console.WriteLine("Tast 1 for Firkant, Tast 2 for Trekant, Tast 3 for Cirkel");

                String str = Console.ReadLine();
                Console.Clear();
                /*
                hopper til Case som bruger taster ind til at lave den udregning der skal laves
                */
                switch (str)
                {
                    case ("1"):
                        //Firkant
                        firkant();

                        break;
                    case ("2"):
                        //Trekant
                        trekant();

                        break;
                    case ("3"):
                        //Cirkle
                        cirkel();
                        break;
                }

                Console.WriteLine("Ønsker du at prøve igen? ja/nej");

                /*
                  Console.ReadLine(Læser indtast fra Bruger);
                */
                svar = Console.ReadLine();
                Console.Clear();
                svar = svar.ToLower();
            } while (svar == "j" || svar == "ja");
        }

        private static double spørgsmål(string spørgsmål)
        {
            Console.WriteLine(spørgsmål);
            string userinput = Console.ReadLine();
            double d;
            while (!double.TryParse(userinput, out d))
            {
                Console.WriteLine("Tallet var hverken 1, 2, eller 3, prøv igen");
                userinput = Console.ReadLine();
            }

            return d;
        }

        private static void firkant()
        {
            Console.WriteLine("Du har nu valgt en Firkant");
            double input = spørgsmål("tast 1 for Arealet, tast 2 for rumfanget, tast 3 for omkreds.");
            double tal1 = spørgsmål("indtast højden af firkenten");
            double tal2 = spørgsmål("indtast længden af firkenten");
            double tal3;
            switch (input)
            {
                case 1:
                    Console.WriteLine("vi beregner arealet af denne firkant ved at tage højden af firkaneten * længden af firkanten\n" + tal1 + " * " + tal2 + " = " + tal1 * tal2);
                    break;
                case 2:
                    tal3 = spørgsmål("indtast dybten af firkanten");
                    Console.WriteLine("vi beregner rumfanget af denne firkant ved at tage højden af firkaneten * længden af firkanten * dybten af firkanten\n" + tal1 + " * " + tal2 + " * " + tal3 + " = " + tal1 * tal2 * tal3);
                    break;
                case 3:
                    Console.WriteLine("vi beregner omkreds af denne firkant ved at tage højden af firkaneten + længden af firkanten * 2 \n" + "2" + " * " + "(" + tal1 + " + " + tal2 + ")" + " = " + 2 * (tal1 + tal2));
                    break;
            }
        }

        private static void trekant()
        {
            Console.WriteLine("Du har nu valgt en trekant");
            double input = spørgsmål("tast 1 for Arealet, tast 2 for rumfanget, tast 3 for omkreds.");
            double tal1 = spørgsmål("indtast højden af trekanten");
            double tal2 = spørgsmål("indtast grundlingen af trekanten");
            double tal3;
            switch (input)
            {
                case 1:
                    Console.WriteLine("vi beregner arealet af denne trekant ved at tage højden af trekanten * grundlingen af trekanten / 2 \n(" + tal1 + " * " + tal2 + ") / 2 = " + (tal1 * tal2) / 2);
                    break;
                case 2:
                    tal3 = spørgsmål("indtast længden af trekanten");
                    Console.WriteLine("vi beregner rumfanget af denne trekant ved at tage højden af trekanten * længden af trekanten * grundlinge af trekanten / 2\n(" + tal1 + " * " + tal2 + " * " + tal3 + ") / 2 = " + (tal1 * tal2 * tal3) / 2);
                    break;
                case 3:
                    tal3 = spørgsmål("indtast længden af trekanten");
                    Console.WriteLine("vi beregner omkredsen af denne trekant ved at tage højden af trekanten + længden af trekanten + grundlingen af trekanten\n" + tal1 + " + " + tal2 + " + " + tal3 + " = " + (tal1 + tal2 + tal3));
                    break;
            }
        }

        private static void cirkel()
        {
            Console.WriteLine("Du har nu valgt en Cirkel");
            double input = spørgsmål("tast 1 for Arealet, tast 2 for omkreds, tast 3 for rumfang af en cylender.");
            double tal1 = spørgsmål("intast radius");
           
            switch (input)
            {
                case 1:
                    Console.WriteLine("vi beregner areal af denne circle ved at tage Radius * Radius * med pi\n" + tal1 + " * " + tal1 + " * pi = " + Math.Pow(tal1, 2) * Math.PI);
                    break;
                case 2:
                    Console.WriteLine("vi beregner omkredsen af denne circle ved at tage Radius * 2 * pi\n" + tal1 + " * 2 * pi = " + (tal1 * 2 * Math.PI));
                    break;
                case 3:
                    double tal2 = spørgsmål("intast højden");
                    Console.WriteLine("vi beregner rumfanget af en circkle som har skriftet navn til en cylender pi * r2 * h\n" + tal1 + " * " + tal1+ " * pi * " + tal2 + " = " +(tal1 * tal1 * Math.PI * tal2));
                    break;
            }
        }
    }
}
