using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
  
    class App
    {
        static public void Main(String[] args)
        {
            Circle circle = new Circle(10);
            Ellipse ellipse = new Ellipse(5, 10);
            Rectangle rectangle = new Rectangle(10,12);
            Rectangle rectangle1 = new Rectangle(rectangle);
            Pentagon pentagon = new Pentagon(4);
            Square square = new Square(10);

            Form1 newForm = new Form1();

            //wrote WriteLine method in Form 1 to display text:
            newForm.WriteLine( "Area of a Circle with radius 10-     " + circle.calculateArea().ToString());
            newForm.WriteLine("Circumference of a Circle with radius 10-     " + circle.calculatePerimeter().ToString());
            newForm.WriteLine("The area of an ellipse with semiminor axis = 10  and semimajor axis = 5-    " + ellipse.calculateArea().ToString());
            newForm.WriteLine("The circumference apporximation of an ellipse with semiminor axis = 10 and semimajor axis = 5-    " + ellipse.calculateArea().ToString());
            newForm.WriteLine("The area of rectangle of height 10 and width 12-    " + rectangle.calculateArea().ToString());
            newForm.WriteLine("The area of rectangle that is a copy of the above rectangle (using copy constructor)-    " + rectangle1.calculateArea().ToString());
            newForm.WriteLine("The area of rectangle of height 10 and width 12-   " + rectangle.calculatePerimeter().ToString());
            newForm.WriteLine("The area of rectangle that is a copy of the above rectangle (using copy constructor)-     " + rectangle1.calculatePerimeter().ToString());
            newForm.WriteLine("The area of a pentagon of side 4-     " + pentagon.calculateArea().ToString());
            newForm.WriteLine("The perimeter of a pentagon of side 4-     " + pentagon.calculatePerimeter().ToString());
            newForm.WriteLine("The area of square of size 10-    " + square.calculateArea().ToString());
            newForm.WriteLine("The perimeter of square of size 10-    " + square.calculatePerimeter().ToString());


            //runs form in main
            Application.Run(newForm);

        }
    }
}
