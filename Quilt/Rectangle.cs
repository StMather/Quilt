using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt
{
    public class Rectangle : Shape
    {
        private double side1;
        private double side2;
        public Rectangle (string colorIn, double side1In, double side2In)
        {
            color = colorIn;
            side1 = side1In;
            side2 = side2In;
            shapeName = "Rectangle";
        }
        public override double GetArea()
        {
            return side1 * side2;
        }
    }
}
