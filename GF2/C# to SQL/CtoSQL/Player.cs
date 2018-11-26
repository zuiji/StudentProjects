using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoSQL
{
    class Player
    {
        public int id;
        public string Name;
        public DateTime Birthdate;
        public int CS_TeamID;
        public Dictionary<string,Players_To_Arcade_Games> Player_Games;
        

    }
}
