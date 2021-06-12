using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Pentagon
    {
        private double sidelength { get; set; }
        public Pentagon()
        {
            this.sidelength = 0;
           
        }

        public Pentagon(double side)
        {
            this.sidelength = side;
        }

        public Pentagon(Pentagon other)
        {
            this.sidelength = other.sidelength;
        }

        public double calculateArea()
        {
            double constant = .25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));

            return constant * this.sidelength * this.sidelength;
        }

        public double calculatePerimeter()
        {
            return 5 * this.sidelength;
        }
    }
}
