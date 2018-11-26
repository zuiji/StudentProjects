using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_kode_Green
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string A = ".-";
            string B = "-...";
            string C = "-.-.";
            string D = "-..";
            string E = ".";
            string F = "..-";
            string G = "--.";
            string H = "....";
            string I = "..";
            string J = ".---";
            string K = "-.-";
            string L = ".-..";
            string M = "--";
            string N = "-.";
            string O = "---";
            string P = ".--.";
            string Q = "--.-";
            string R = ".-.";
            string S = "...";
            string T = "-";
            string U = "..-";
            string V = "...-";
            string W = ".--";
            string X = "-..-";
            string Y = "-.--";
            string Z = "--..";
            string Æ = ".-.-";
            string Ø = "---.";
            string Å = ".--.-";
            #endregion

            Console.WriteLine("Indtast den tekst du ønsker at få oversat til morsekode");
            string text = Console.ReadLine();
            char[] chararray = text.ToUpper().ToCharArray();
            
            for (int i = 0; i < chararray.Length; ++i)
            {
                switch (chararray[i])
                {
                    #region case
                    case 'A':
                        Console.Write("\t.- \t");
                        break;
                    case 'B':
                        Console.Write("\t-... \t");
                        break;
                    case 'C':
                        Console.Write("\t-.-. \t");
                        break;
                    case 'D':
                        Console.Write("\t-.. \t");
                        break;
                    case 'E':
                        Console.Write("\t. \t");
                        break;
                    case 'F':
                        Console.Write("\t..- \t");
                        break;
                    case 'G':
                        Console.Write("\t--. \t");
                        break;
                    case 'H':
                        Console.Write("\t.... \t");
                        break;
                    case 'I':
                        Console.Write("\t.. \t");
                        break;
                    case 'J':
                        Console.Write("\t.--- \t");
                        break;
                    case 'K':
                        Console.Write("\t-.- \t");
                        break;
                    case 'L':
                        Console.Write("\t.-.. \t");
                        break;
                    case 'M':
                        Console.Write("\t-- \t");
                        break;
                    case 'N':
                        Console.Write("\t-. \t");
                        break;
                    case 'O':
                        Console.Write("\t--- \t");
                        break;
                    case 'P':
                        Console.Write("\t.--. \t");
                        break;
                    case 'Q':
                        Console.Write("\t--.- \t");
                        break;
                    case 'R':
                        Console.Write("\t.-. \t");
                        break;
                    case 'S':
                        Console.Write("\t... \t");
                        break;
                    case 'T':
                        Console.Write("\t- \t");
                        break;
                    case 'U':
                        Console.Write("\t..- \t");
                        break;
                    case 'V':
                        Console.Write("\t...- \t");
                        break;
                    case 'W':
                        Console.Write("\t.-- \t");
                        break;
                    case 'X':
                        Console.Write("\t-..- \t");
                        break;
                    case 'Y':
                        Console.Write("\t-.-- \t");
                        break;
                    case 'Z':
                        Console.Write("\t--.. \t");
                        break;
                    case 'Æ':
                        Console.Write("\t.-.- \t");
                        break;
                    case 'Ø':
                        Console.Write("\t---. \t");
                        break;
                    case 'Å':
                        Console.Write("\t.--.- \t");
                        break;
                    default:
                        Console.Write(" ");
                        break;
                    #endregion

                }
                Console.WriteLine(chararray[i]);
            }
            Console.ReadLine();
        }
    }
}
