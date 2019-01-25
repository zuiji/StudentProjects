using System;
using System.Collections.Generic;
using System.Globalization;

namespace PortoBeregner
{
    class Program
    {
        private static List<string> typestring = new List<string>();
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Post post = new Post();
            post.PType = GetAnswers.GetChoiceFromListAsInt("Hvilken type post vil du sende", "Brev", "Pakke");
            Console.Clear();
            Console.Write("Hvad er vægten");
            if (post.PType == 0)
                Console.WriteLine(" i gram");
            else
                Console.WriteLine(" i kilo");
            post.Weight = int.Parse(Console.ReadLine());
            Console.Clear();
            if (post.PType == 0)
            {
                post.Countrytype = GetAnswers.GetChoiceFromListAsInt("Hvad land vil du sende til", "Danmark", "Alle andre lande");
            }
            else
            {
                post.Countrytype = GetAnswers.GetChoiceFromListAsInt("Hvad land vil du sende til\n\nEuropa1 = \"Belgien, Bulgarien, Cypern, Estland, Finland, Frankrig, Irland, Italien, Kroatien, Letland, Litauen, Luxembourg, Malta,Nederlandene, Polen, Portugal, Rumænien, Slovakiet, Slovenien, Spanien, Storbritannien, Sverige, Tjekkiet, Tyskland, Ungarn og Østrig\"\n\nEuropa 2 = Albanien, Andorra, Armenien, Azerbajdzhan, Azorerne, Bosnien Herzegovina, Canariske Øer, Cypern(tyrkiske del), Georgien, Gibraltar\"", "Danmark", "Færgøerne", "Grøndland", "Europa 1", "Europa 2", "Alle andre lande ");
            }
            Console.Clear();
            decimal price = post.getprice();
            if (price == -1)
                Console.WriteLine("Du kan ikke sænde så tunge pakke til den lokation");
            else
                Console.WriteLine(post.getprice().ToString("c", CultureInfo.CreateSpecificCulture("da-DK")));

        }

    }
}
