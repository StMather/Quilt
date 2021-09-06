using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt
{
    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(string colorIn, double side1In, double side2In, double side3In)
        {
            color = colorIn;
            side1 = side1In;
            side2 = side2In;
            side3 = side3In;
            shapeName = "Triangle";
        }
        public override double GetArea()
        {
            double temp = (side1 + side2 + side3) / 2;
            return (Math.Sqrt(temp * side1 * side2 * side3));
        }
    }
}
