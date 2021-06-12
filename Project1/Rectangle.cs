using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Rectangle
    {
        private double width { get; set; }

        private double height { get; set; }
        public Rectangle()
        {
            this.width = 0;
            this.height = 0;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(Rectangle other)
        {
            this.width = other.width;
            this.height = other.height;
        }

        public double calculateArea()
        {
            return width * height;
        }

        public double calculatePerimeter()
        {
            return width * 2 + height * 2;
        }
    }
}
