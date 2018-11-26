using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_beregner_A_eller_B_metode
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Post post = new Post();
            post.Ptype =
                GetAnswers.GetChoiceFromListAsInt("what type of mail do you want you sent", "Ekspress", "Regulary");
            Console.Clear();
            Console.WriteLine("what is the Wight?");
            if (post.Ptype == 0)
                Console.WriteLine("in gram");
            else
                Console.WriteLine(" in gram");
            post.Weight = int.Parse(Console.ReadLine());
            Console.Clear();
            if (post.Ptype == 0)
            {
                post.Contrytype = GetAnswers.GetChoiceFromListAsInt("What contry do you wish to send it to", "Denmark", "Europa Greenland færøerne",
                    "All other contry's");
            }
            else
            {
                post.Contrytype = GetAnswers.GetChoiceFromListAsInt("What contry do you wish to send it to", "Denmark" ,"Europa Greenland færøerne",
                    "All other contry's");
            }
            Console.Clear();
            var price = post.getPrice();
            if (price == -1)
                Console.WriteLine("You cant send a letter that heavy to the distanation");
            else
                Console.WriteLine(post.getPrice().ToString("c", new CultureInfo("dk-DK")));
            Console.ReadKey();
        }

    }
}
