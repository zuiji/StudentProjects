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
