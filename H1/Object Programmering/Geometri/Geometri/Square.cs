using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {

        public double sides
        {
            get; set;

        }

        public Square()
        {

        }
        public Square(double sides)
        {
            this.sides = sides;
        }

        public double Perimeter()
        {
            double peri;
            peri = sides * 4;
            return peri;
        }

        public double area()
        {
            double area;
            area = sides * sides;
            return area;

        }

    }
}
