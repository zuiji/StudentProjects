using System.Collections.Generic;

namespace Libarry.Logi
{
    public class ListOfBook
    {
        List<Book> biblotek = new List<Book>();

        public List<Book> Biblotek
        {
            get {return biblotek;}

            set {biblotek = value;}

        }
        
    }
}