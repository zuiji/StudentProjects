using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Morsekoder
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

            Console.WriteLine("Enter the text you want to translate to morse code");
            string inputfromuser = Console.ReadLine().ToUpper();
            char[] chararray = inputfromuser.ToCharArray();
            StringBuilder morse = new StringBuilder();
            for (int i = 0; i < chararray.Length; i++)
            {


                switch (chararray[i])
                {
                    #region case

                    case 'A':
                        morse.Append(" .-");
                        break;
                    case 'B':
                        morse.Append(" -...");
                        break;
                    case 'C':
                        morse.Append(" -.-.");
                        break;
                    case 'D':
                        morse.Append(" -..");
                        break;
                    case 'E':
                        morse.Append(" .");
                        break;
                    case 'F':
                        morse.Append(" ..-");
                        break;
                    case 'G':
                        morse.Append(" --.");
                        break;
                    case 'H':
                        morse.Append(" ....");
                        break;
                    case 'I':
                        morse.Append(" ..");
                        break;
                    case 'J':
                        morse.Append(" .---");
                        break;
                    case 'K':
                        morse.Append(" -.-");
                        break;
                    case 'L':
                        morse.Append(" .-..");
                        break;
                    case 'M':
                        morse.Append(" --");
                        break;
                    case 'N':
                        morse.Append(" -.");
                        break;
                    case 'O':
                        morse.Append(" ---");
                        break;
                    case 'P':
                        morse.Append(" .--.");
                        break;
                    case 'Q':
                        morse.Append(" --.-");
                        break;
                    case 'R':
                        morse.Append(" .-.");
                        break;
                    case 'S':
                        morse.Append(" ...");
                        break;
                    case 'T':
                        morse.Append(" -");
                        break;
                    case 'U':
                        morse.Append(" ..-");
                        break;
                    case 'V':
                        morse.Append(" ...-");
                        break;
                    case 'W':
                        morse.Append(" .--");
                        break;
                    case 'X':
                        morse.Append(" -..-");
                        break;
                    case 'Y':
                        morse.Append(" -.--");
                        break;
                    case 'Z':
                        morse.Append(" --..");
                        break;
                    case 'Æ':
                        morse.Append(" .-.-");
                        break;
                    case 'Ø':
                        morse.Append(" ---.");
                        break;
                    case 'Å':
                        morse.Append(" .--.-");
                        break;
                    default:
                        Console.Write(" ");
                        break;
                        #endregion
                }

               
            }
            Console.WriteLine(morse);
        }
    }
}
