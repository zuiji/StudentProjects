using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Markup;

namespace CtoSQL
{
    class Program
    {

        public static void Clear()
        {
            /*        
            4system.environment.username udskriver brugerens login name fra pc.   
            */
            Console.Clear();
            Console.WriteLine("Hello " + System.Environment.UserName + " Welcome to My Awesome Gaming system");
        }

        static string connectionString = "SERVER = DESKTOP-0G2P1OQ; DATABASE = Alpha;Integrated Security=true;";
        static SqlConnection sqlconn = new SqlConnection(connectionString);


        static void Main(string[] args)
        {
            sqlconn.Open();
            char inputFromUser;
            Clear();
            do
            {

                Console.WriteLine("Press 1 for print User-list:\nPress 2 to Add-User:\nPress 9 to exit the program:");
                inputFromUser = Console.ReadKey(true).KeyChar;

                switch (inputFromUser)
                {
                    case '1':
                        inputFromUser = Choice1();
                        Clear();
                        break;
                    case '2':
                        inputFromUser = Choise2();
                        Clear();
                        break;
                    case '9':
                        Clear();
                        break;
                    default:
                        Clear();
                        Console.WriteLine("Error try again.");
                        break;
                }
            } while (inputFromUser != '9');
            Console.Clear();
            Console.WriteLine("Goodbye " + System.Environment.UserName);
            sqlconn.Close();
        }

        public static char Choice1()
        {
            Clear();
            char inputFromUser;
            do
            {


                /*
                Oprette en Dictionary hvor vi gemmer brugere oplysninger i. 
                så vi kan arbejde med dem senere i programment. 
                og stadigvæk få dem udstrevet. 

                 */


                SqlCommand cmd = new SqlCommand("SELECT ID, Name, CS_TeamID FROM CS_Players", sqlconn);

                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<int, Player> Players = new Dictionary<int, Player>();

                while (reader.Read())
                {
                    Player currentPlayer = new Player();
                    currentPlayer.id = Convert.ToInt32(reader.GetValue(0));
                    currentPlayer.Name = reader.GetValue(1).ToString();
                    int TeamID;
                    if (int.TryParse(reader.GetValue(2).ToString(), out TeamID))
                    {
                        currentPlayer.CS_TeamID = TeamID;
                    }

                    currentPlayer.CS_TeamID = 0;

                    Players.Add(currentPlayer.id, currentPlayer);
                    Console.WriteLine("ID " + reader.GetValue(0).ToString().PadLeft(5) + " NAME " + reader.GetValue(1).ToString().PadRight(20) + " TeamID " + reader.GetValue(2).ToString().PadLeft(2));

                }

                reader.Close();

                Console.WriteLine("Press 1 for Delete an User:\nPress 2 for Games:\nPress 8 for Return to main menu:\nPress 9 for ending the program:");
                inputFromUser = Console.ReadKey(true).KeyChar;
                switch (inputFromUser)
                {
                    case '1':
                        inputFromUser = DeleteUser(Players);
                        Clear(); break;
                    case '2':
                        inputFromUser = Games(Players);
                        Clear(); break;
                    case '8':
                    case '9': Clear(); break;
                    default:
                        Clear();
                        Console.WriteLine("Error try again.");
                        break;
                }

            } while (inputFromUser != '8' && inputFromUser != '9');


            return inputFromUser;
        }

        public static char Choise2()
        {
            string Birthdate = "'2000-01-01'";
            string Name = "'søren hansen'";
            int CS_TeamID = 0;
            Console.WriteLine("Insert Name and last Name");
            Name = Console.ReadLine();
            Console.WriteLine("Insert Birthday in this format: Year - month - day/nex: 2000-01-01");
            Birthdate = Console.ReadLine();
            Console.WriteLine("insert CS__TeamID");
            CS_TeamID = Convert.ToInt32(Console.ReadLine());

            String insertQuery = "iNSERT INTO CS_Players (Name, Birthdate, CS_TeamID)" + "VALUES " + ("( '" + Name + "' ,  '" + Birthdate + "' , " + CS_TeamID + ")");
            Console.WriteLine(insertQuery);
            SqlCommand MyCmdInsert = new SqlCommand(insertQuery, sqlconn);

            MyCmdInsert.ExecuteNonQuery();

            Console.WriteLine("You are now Registered in the databases");
            Console.WriteLine("Press 9 to exit the program:\t and any other key to return to main menu:");
            return Console.ReadKey(true).KeyChar;
        }

        public static char DeleteUser(Dictionary<int, Player> Players)
        {
            int inputFromUser;
            Console.WriteLine("Inset ID on the User you want to delete.");
            bool s = false;
            do
            {
                bool parsesuccess = int.TryParse(Console.ReadLine(), out inputFromUser);
                if (!parsesuccess || !Players.ContainsKey(inputFromUser))
                {
                    Console.WriteLine("Wrong did not success try another key. ");
                    s = false;
                }
                else
                {
                    s = true;
                }

            } while (!s);

            String DeleteQuery = "Delete From CS_Players where CS_Players.ID = " + inputFromUser;

            SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, sqlconn);
            DeleteCommand.ExecuteNonQuery();
            Clear();
            Console.WriteLine("You have now deleted an User in the databases");
            Console.WriteLine("Press 8 to return to main menu:\nPress 9 to exit the program:\nAnd any other key to return to previous menu:");
            return Console.ReadKey(true).KeyChar;
        }

        public static char Games(Dictionary<int, Player> Players)
        {
            int inputFromUser;

            Console.WriteLine("Inset ID on the User you want to see games for.");
            bool s = false;
            do
            {
                bool parsesuccess = int.TryParse(Console.ReadLine(), out inputFromUser);
                if (!parsesuccess || !Players.ContainsKey(inputFromUser))
                {
                    Console.WriteLine("Wrong did not success try another key. ");
                }
                else
                {
                    s = true;
                }

            } while (!s || !Players.ContainsKey(inputFromUser));

            int playerid = inputFromUser;
            Clear();
            do
            {

                SqlCommand cmd = new SqlCommand("SELECT Name, HIGHSCORE, ARCADE_GAMES_ID From PLAYERS_TO_ARCADE_GAMES JOIN ARCADE_GAME ON(PLAYERS_TO_ARCADE_GAMES.ARCADE_GAMES_ID = ARCADE_GAME.ID) where PLAYER_ID =" + playerid, sqlconn);

                SqlDataReader reader = cmd.ExecuteReader();

                Players[playerid].Player_Games = new Dictionary<string, Players_To_Arcade_Games>();
                while (reader.Read())
                {
                    Players_To_Arcade_Games currentPlayer = new Players_To_Arcade_Games();
                    currentPlayer.Name = reader.GetValue(0).ToString();
                    currentPlayer.HighScore = reader.GetValue(1).ToString();
                    currentPlayer.Game_ID = reader.GetValue(2).ToString();
                    Players[playerid].Player_Games.Add(currentPlayer.Game_ID, currentPlayer);

                }

                var player = Players[playerid];
                foreach (var playersToArcadeGamese in Players[playerid].Player_Games.Values)
                {
                    Console.WriteLine("ID: " + playersToArcadeGamese.Game_ID + "\tname: " + playersToArcadeGamese.Name + "\thigh score: " + playersToArcadeGamese.HighScore);
                }

                reader.Close();

                Console.WriteLine("Press 1 to set the high score:\nPress 2 for Add game to your Play List:\nPress 3 to delete a game from the user:\nPress 8 to go to the main menu:\nPress 9 to end the program:");
                inputFromUser = Console.ReadKey(true).KeyChar;
                switch (inputFromUser)
                {
                    case '1':
                        inputFromUser = highscore(player);
                        Clear(); break;
                    case '2':
                        inputFromUser = addgame(player);
                        Clear(); break;
                    case '3':
                        inputFromUser = Deletegames(player);
                        Clear(); break;
                    case '8':
                    case '9': Clear(); break;
                    default:
                        Clear();
                        Console.WriteLine("Error try agian.");
                        break;
                }
            } while (inputFromUser != '8' && inputFromUser != '9');
            return (char)inputFromUser;
        }

        public static char highscore(Player player)
        {
            string gameID;
            string inputFromUser;
            Console.WriteLine("Inset ID on the game you want to edit high score for.");
            do
            {
                inputFromUser = Console.ReadLine();
                if (!player.Player_Games.ContainsKey(inputFromUser))
                {
                    Console.WriteLine("Wrong did not success try another key. ");
                }



            } while (!player.Player_Games.ContainsKey(inputFromUser));

            gameID = inputFromUser;

            Console.WriteLine("Inset the new high score for the game");

            bool s = false;
            do
            {
                bool parsesuccess = int.TryParse(Console.ReadLine(), out int highscore);
                if (!parsesuccess)
                {
                    Console.WriteLine("Wrong did not success try another key. ");
                }
                else
                {
                    inputFromUser = highscore.ToString();
                    s = true;
                }

            } while (!s);

            SqlCommand cmd = new SqlCommand("UPDATE PLAYERS_TO_ARCADE_GAMES SET Highscore = " + inputFromUser + " WHERE PLAYER_ID = " + player.id + " and ARCADE_Games_ID = " + gameID, sqlconn);
            cmd.ExecuteNonQuery();
            Clear();
            Console.WriteLine("HighScore has now been updated");
            Console.WriteLine("Press 8 to return to main menu:\nPress 9 to exit the program:\nAnd any other key to return to previous menu:");
            return Console.ReadKey(true).KeyChar;
        }

        public static char addgame(Player player)
        {
            Clear();
            SqlCommand cmd = new SqlCommand("SELECT distinct ARCADE_GAMES_ID, Name From ARCADE_GAME Join PLAYERS_TO_ARCADE_GAMES on (PLAYERS_TO_ARCADE_GAMES.ARCADE_GAMES_ID = ARCADE_GAME.ID)" +
                "except(select ARCADE_GAMES_ID, Name From ARCADE_GAME Join PLAYERS_TO_ARCADE_GAMES on(PLAYERS_TO_ARCADE_GAMES.ARCADE_GAMES_ID = ARCADE_GAME.ID) where PLAYER_ID = " + player.id + ")", sqlconn);


            SqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, Players_To_Arcade_Games> unusedgames = new Dictionary<string, Players_To_Arcade_Games>();
            while (reader.Read())
            {
                Players_To_Arcade_Games currentPlayer = new Players_To_Arcade_Games();
                currentPlayer.Name = reader.GetValue(1).ToString();
                currentPlayer.Game_ID = reader.GetValue(0).ToString();
                unusedgames.Add(currentPlayer.Game_ID, currentPlayer);

            }

            reader.Close();
            foreach (var playersToArcadeGamese in unusedgames.Values)
            {
                Console.WriteLine("ID: " + playersToArcadeGamese.Game_ID + "\tname: " + playersToArcadeGamese.Name);
            }

            Console.WriteLine("insert what \"ID\" of the game you want to add on your game list.");
            string inputFromUser;
            do
            {
                inputFromUser = Console.ReadLine();
                if (!unusedgames.ContainsKey(inputFromUser))
                {
                    Console.WriteLine("Wrong did not success try another key. ");
                }
            } while (!unusedgames.ContainsKey(inputFromUser));
            String insertQuery = "iNSERT INTO PLAYERS_TO_ARCADE_GAMES (PLAYER_ID, ARCADE_GAMES_ID)" + "VALUES " + ("( '" + player.id + "' ,  '" + inputFromUser + "')");
            Console.WriteLine(insertQuery);
            SqlCommand MyCmdInsert = new SqlCommand(insertQuery, sqlconn);

            MyCmdInsert.ExecuteNonQuery();
            Clear();
            Console.WriteLine("You have now added A game to User with name \"" + player.Name + "\"");
            Console.WriteLine("Press 8 to return to main menu:\nPress 9 to exit the program:\nAnd any other key to return to previous menu:");
            return Console.ReadKey(true).KeyChar;
        }

        public static char Deletegames(Player player)
        {
            string gameID;
            string inputFromUser;
            Console.WriteLine("Inset ID on the Game you want to delete.");
            do
            {
                inputFromUser = Console.ReadLine();
                if (!player.Player_Games.ContainsKey(inputFromUser))
                {
                    Console.WriteLine("Wrong did not success try another key. ");
                }



            } while (!player.Player_Games.ContainsKey(inputFromUser));

            String DeleteQuery = "Delete From PLAYERS_TO_ARCADE_GAMES WHERE PLAYER_ID = " + player.id + " and ARCADE_Games_ID = " + inputFromUser;

            SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, sqlconn);
            DeleteCommand.ExecuteNonQuery();
            Clear();
            Console.WriteLine("You have now deleted a Game from the User");

            Console.WriteLine("Press 8 to return to main menu:\nPress 9 to exit the program:\nAnd any other key to return to previos menu:");
            return Console.ReadKey(true).KeyChar;
        }
    }
}