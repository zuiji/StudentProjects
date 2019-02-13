using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Filer_og_mapper_med_metode
{
    class Program
    {
        static void Main(string[] args)
        {



            CreateTxTFile();

            ReadTxTFile();

            DeleteTxTFile();

            CreateFolderAndTxt();

            DeleteFolderAndFiles();

            EnumerateFiles();

            StreamReaderFromTxt();

            StreamWriterToTxT();
            Console.WriteLine(@"
1: Add file 
2: Delete file
3: Display files
4: Add folder
5: Search file
6: Other stuff ex JPEG
7: Exit
            ");
            Console.WriteLine("type in a number of what exersice you want to do.. ");
            char MainMenu = Console.ReadKey().KeyChar;

            switch (MainMenu)
            {
                case '1':
                    CreateTxTFile();
                    break;
                case '2':
                    DeleteTxTFile();
                    break;
                case '3':
                    EnumerateFiles();
                    break;
                case '4':
                    CreateFolderAndTxt();
                    break;
                case '5':

                    break;
                case '6':

                    break;
                case '7':
                    Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Wrong keyChar try with 1 - 7, Please :') ");
                    break;
            }


        }

        private static void StreamWriterToTxT()
        {
            List<string> actors = new List<string>()
            {
                "Mark Hamill",
                "Harrison Ford",
                "Carrie Fisher"
            };
            FileStream file = new FileStream(@".\Movies.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (string actor in actors)
                {
                    writer.WriteLine(actor);
                }
            }
        }

        private static void StreamReaderFromTxt()
        {
            File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi\n");
            FileStream file = new FileStream(@".\Movies.txt", FileMode.Open);

            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }

                reader.Close();
            }

            file.Close();
        }

        private static void EnumerateFiles()
        {
            Directory.CreateDirectory(@".\Droids\Astromech");
            Directory.CreateDirectory(@".\Droids\Protocol");
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
            File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "Sir!");
            string[] Files = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);
            foreach (string File in Files)
            {
                Console.WriteLine(File);
            }
        }

        private static void DeleteFolderAndFiles()
        {
            Directory.Delete(@".\Droids", true);
        }

        private static void CreateFolderAndTxt()
        {
            Directory.CreateDirectory(@".\Droids");
            File.WriteAllText(@".\Droids\R2D2.txt", "beep bop");
        }

        private static void DeleteTxTFile()
        {
            File.Delete(@".\StarWars.txt");
        }

        private static void ReadTxTFile()
        {
            string content = File.ReadAllText(@".\StarWars.txt");
            Console.WriteLine(content);
        }

        private static void CreateTxTFile()
        {
            File.WriteAllText(@".\StarWars.txt", "Han skød først");
        }
    }
}
