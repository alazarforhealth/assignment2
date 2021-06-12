using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Circle
    {
        private double radius { get; set; }
        public Circle()
        {
            this.radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(Circle other)
        {
            this.radius = radius;
        }

        public double calculateArea()
        {
            return radius * radius * Math.PI;
        }

        public double calculatePerimeter()
        {
            return radius * 2 * Math.PI;
        }
    }
}
