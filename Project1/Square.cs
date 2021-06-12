using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Square
    {
        private double lengthOfSide { get;  set; }


        public Square()
        {
            lengthOfSide = 0;
        }

        public Square(double lengthOfSide)
        {
            this.lengthOfSide = lengthOfSide;
        }

        public Square(Square other)
        {
            this.lengthOfSide = other.lengthOfSide;
        }

        public double calculateArea()
        {
            return lengthOfSide * lengthOfSide;
        }

        public double calculatePerimeter()
        {
            return lengthOfSide * 4;
        }
    }
}
