using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    public class Planet
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double mass;
        public double Mass
        {
            get { return mass;}
            set { mass = value; }
        }



      
    }
}
