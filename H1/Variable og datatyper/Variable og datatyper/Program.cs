using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_og_datatyper
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Opgave A
            ///<summery>
            /// 
            ///  Erklær en variabel af typen int og tildel den værdien 16, du kan evt. kalde variablen a.
            ///  En variabel erklæres og tildeles værdi således:
            ///  int l = 12;
            ///  Erklær en variabel f.eks.kaldet b, af type double og tildel den værdien 5.1.
            ///  Prøv at lægge de 2 variable sammen i en Console.WriteLine(a + b); i din main metode og se resultatet.
            ///
            /// </summery>


            int a = 16;

            double b = 5.1;

            // if you do a + b its will not multiply it.
            Console.WriteLine(a + b);
            
            // if you do (a + b) its going to multiply it.
            Console.WriteLine(" a + b = " + (a + b));


            #endregion

            #region Opgave B
            ///<summery>
            ///
            ///Prøv at erklære endnu en variabel af type int, du kan kalde variablen c, og tildel den værdierne a+b
            ///int c = a+b;
            ///Visual Studios compiler vil ikke oversætte din kode, men hvorfor?
            ///
            /// 
            /// its will not work as int variable cant hold decimals
            ///
            /// </summery>


            int c = a + b;

            Console.WriteLine(c);


            #endregion
            
            #region Opgave C

            ///<summery>
            ///
            ///Prøv at erklære endnu en variabel af type double, du kan kalde variablen d, og tildel den værdierne a+b
            /// double d = a+b;
            ///Her vil Visual Studio gerne oversætte din kode, men hvorfor nu det?
            ///
            ///
            /// This is working becoase D is a double variable and can hold decimals.
            /// 
            /// </summery>

            double d = a + b;
            Console.WriteLine(d);
            #endregion

        }
    }
}
