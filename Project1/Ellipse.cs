using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Ellipse
    {
        private double SemiMajorAxis { get; set; }
        private double SemiMinorAxis { get; set; }
        public Ellipse()
        {
            this.SemiMajorAxis = 0;
            this.SemiMinorAxis = 0;
        }

        public Ellipse(double SemiMajorAxis, double SemiMinorAxis)
        {
            this.SemiMajorAxis = SemiMajorAxis;
            this.SemiMinorAxis = SemiMinorAxis;
        }

        public Ellipse(Ellipse other)
        {
            this.SemiMajorAxis = other.SemiMajorAxis;
            this.SemiMinorAxis = other.SemiMinorAxis;
        }

        public double calculateArea()
        {
            return SemiMajorAxis * SemiMinorAxis * Math.PI;
        }

        public double calculatePerimeter()
        {

            return Math.PI * (
                3 *(this.SemiMinorAxis+ this.SemiMajorAxis) - Math.Sqrt(
                    (3*this.SemiMajorAxis+this.SemiMinorAxis) * (this.SemiMajorAxis+this.SemiMinorAxis*3)
                    )
                );
        }
    }
}
