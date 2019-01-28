using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeRed
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dictionary

            Dictionary<char, string> morsetranslater = new Dictionary<char, string>();
            morsetranslater.Add('A', ".-");
            morsetranslater.Add('B', "-...");
            morsetranslater.Add('C', "-.-.");
            morsetranslater.Add('D', "-..");
            morsetranslater.Add('E', ".");
            morsetranslater.Add('F', "..-");
            morsetranslater.Add('G', "--.");
            morsetranslater.Add('H', "....");
            morsetranslater.Add('I', "..");
            morsetranslater.Add('J', ".---");
            morsetranslater.Add('K', "-.-");
            morsetranslater.Add('L', ".-..");
            morsetranslater.Add('M', "--");
            morsetranslater.Add('N', "-.");
            morsetranslater.Add('O', "---");
            morsetranslater.Add('P', ".--.");
            morsetranslater.Add('Q', "--.-");
            morsetranslater.Add('R', ".-.");
            morsetranslater.Add('S', "...");
            morsetranslater.Add('T', "-");
            morsetranslater.Add('U', "..-");
            morsetranslater.Add('V', "...-");
            morsetranslater.Add('W', ".--");
            morsetranslater.Add('X', "-..-");
            morsetranslater.Add('Y', "-.--");
            morsetranslater.Add('Z', "--..");
            morsetranslater.Add('Æ', ".-.-");
            morsetranslater.Add('Ø', "---.");
            morsetranslater.Add('Å', ".--.-");



            #endregion

            Console.WriteLine("Enter the text you want to translate to morse code");
            string inputFromUser = Console.ReadLine().ToUpper();
            char[] charArray = inputFromUser.ToCharArray();
            StringBuilder morse = new StringBuilder();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (!morsetranslater.ContainsKey(charArray[i]))
                {
                    morse.Append(" ");
                    continue;
                }
                
                morse.Append(morsetranslater[charArray[i]]);
                
            }

            Console.WriteLine(morse);

        }
    }
} 
