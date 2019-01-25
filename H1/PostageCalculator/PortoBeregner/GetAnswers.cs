using System;

namespace PortoBeregner
{
    class GetAnswers
    {
        /// <summary>
        /// The curser position after the question is written to the console
        /// </summary>
        private static int _afterquestionCurserTop;
        /// <summary>
        /// The string the user is searching after in the answers
        /// </summary>
        private static string _searchstring;

        /// <summary>
        /// Gets the user choice from the user
        /// </summary>
        /// <param name="question">The Question/Choice you want the user to Answer/Make</param>
        /// <param name="answers">The Answers/Choices that the user can choose between</param>
        /// <returns>The answer the user selected as the int representing the position of the answer (starting from 0)</returns>
        public static int GetChoiceFromListAsInt(string question, params string[] answers)
        {
            int index = 0;
            var cursertop = Console.CursorTop;
            ConsoleKey pressedKey = ConsoleKey.Enter;
            Console.CursorVisible = false;

            Console.WriteLine("\n" + question + "\n");
            _afterquestionCurserTop = Console.CursorTop;

            Answers(answers, index);
            var afterAnswersCursertop = Console.CursorTop;
            Console.CursorTop = cursertop + 1;
            do
            {
                MakeAnswerlineNormal(index, answers);

                index = GetNewIndexFromKeyPress(answers, index, pressedKey);
                Clearline(_afterquestionCurserTop + index);
                PrintIndexAnswer(index, answers);

                int beforeReziseCurserTop = Console.CursorTop;
                DateTime timeBetweenKeyPresses = DateTime.Now;
                pressedKey = Console.ReadKey(true).Key;
                if ((DateTime.Now - timeBetweenKeyPresses).Seconds > 1)
                {
                    _searchstring = "";
                }

                CheckForRezise(beforeReziseCurserTop);

            } while (pressedKey != ConsoleKey.Enter);

            Console.CursorTop = cursertop;
            while (Console.CursorTop != afterAnswersCursertop)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth - 1));
            }

            Console.CursorTop = cursertop;
            Console.CursorVisible = true;
            return index;
        }

        /// <summary>
        /// Gets the user choice from the user
        /// </summary>
        /// <param name="question">The Question/Choice you want the user to Answer/Make</param>
        /// <param name="answers">The Answers/Choices that the user can choose between</param>
        /// <returns>The answer the user selected</returns>
        public static string GetChoiseFromListAsString(string question, params string[] answers)
        {
            int index = GetChoiceFromListAsInt(question, answers);
            return answers[index];
        }

        /// <summary>
        /// Checks if the Console.Cursertop has changed do to a resize and makes sure to handle the resize so that the method doesn’t break;
        /// </summary>
        /// <param name="beforeReziseCurserTop">the position og the curserTop before the resize</param>
        private static void CheckForRezise(int beforeReziseCurserTop)
        {
            if (Console.CursorTop < beforeReziseCurserTop)
            {
                _afterquestionCurserTop -= (Math.Abs(Console.CursorTop - beforeReziseCurserTop));
            }
            else if (Console.CursorTop > beforeReziseCurserTop)
            {
                _afterquestionCurserTop += (Math.Abs(Console.CursorTop - beforeReziseCurserTop));
            }
        }

        /// <summary>
        /// Gets the new selected index by checking the keypress.
        /// </summary>
        /// <param name="answers">The Answers/Choices that the user can choose between</param>
        /// <param name="index">The current index</param>
        /// <param name="pressedKey">The key that was pressed by the user</param>
        /// <returns></returns>
        private static int GetNewIndexFromKeyPress(string[] answers, int index, ConsoleKey pressedKey)
        {
            switch (pressedKey)
            {
                case ConsoleKey.UpArrow:
                    index--;
                    if (index < 0)
                        index = answers.Length - 1;
                    _searchstring = "";
                    break;
                case ConsoleKey.DownArrow:
                    index++;
                    if (index >= answers.Length)
                        index = 0;
                    _searchstring = "";
                    break;
                case ConsoleKey.PageUp:
                    index -= 5;
                    if (index < 0)
                        index = 0;
                    _searchstring = "";
                    break;
                case ConsoleKey.PageDown:
                    index += 5;
                    if (index >= answers.Length)
                        index = answers.Length - 1;
                    _searchstring = "";
                    break;
                case ConsoleKey.End:
                    index = answers.Length - 1;
                    _searchstring = "";
                    break;
                case ConsoleKey.Home:
                    index = 0;
                    _searchstring = "";
                    break;
                case ConsoleKey.Enter:
                    _searchstring = "";
                    break;
                default:
                    string pressedkey = pressedKey.ToString().ToLower();
                    _searchstring += pressedkey;
                    bool dobreak = FindMachingAnswerIndex(answers, ref index);
                    if (dobreak)
                    {
                        break;
                    }
                    else if (_searchstring.Length > 1 && answers[index].StartsWith(_searchstring))
                    {
                        break;
                    }
                    _searchstring = pressedkey;
                    FindMachingAnswerIndex(answers, ref index);
                    break;

            }

            return index;
        }

        /// <summary>
        /// checks if any of the answers starts with the characters the user searches for
        /// </summary>
        /// <param name="answers">The Answers/Choices that the user can choose between</param>
        /// <param name="index">the current index (changes if answer is found)</param>
        /// <returns>whether an answer matching the search was found</returns>
        private static bool FindMachingAnswerIndex(string[] answers, ref int index)
        {
            for (int i = index + 1; i < answers.Length; i++)
            {
                if (answers[i].ToLower().StartsWith(_searchstring))
                {
                    index = i;
                    return true;
                }
            }

            for (int i = 0; i < index - 1; i++)
            {
                if (answers[i].ToLower().StartsWith(_searchstring))
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// prints the answers and highlights the selected answer
        /// </summary>
        /// <param name="answers">The Answers/Choices that the user can choose between</param>
        /// <param name="index">the current index</param>
        private static void Answers(string[] answers, int index)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                if (i == index)
                {
                    PrintIndexAnswer(i, answers);
                }
                else
                {
                    Console.WriteLine(answers[i]);
                }
            }
        }

        /// <summary>
        /// prints out the answer corresponding to the current index in the highlighted form
        /// </summary>
        /// <param name="index">the current index</param>
        /// <param name="answers">The Answers/Choices that the user can choose between</param>
        private static void PrintIndexAnswer(int index, string[] anwers)
        {
            Console.SetCursorPosition(0, _afterquestionCurserTop + index);
            var foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (foregroundColor == ConsoleColor.Cyan)
                Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(anwers[index]);
            Console.ForegroundColor = foregroundColor;
        }
        /// <summary>
        /// prints out the answer corresponding to the current index in the not highlighted form
        /// </summary>
        /// <param name="index"></param>
        /// <param name="answers"></param>
        private static void MakeAnswerlineNormal(int index, string[] answers)
        {
            Console.SetCursorPosition(0, _afterquestionCurserTop + index);
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.CursorLeft = 0;
            Console.WriteLine(answers[index]);
        }

        /// <summary>
        /// clears the line specified
        /// </summary>
        /// <param name="linenumber">the line you want to be cleared</param>
        private static void Clearline(int linenumber)
        {
            Console.CursorTop = linenumber;
            Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
            Console.CursorLeft = 0;
        }
    }
}