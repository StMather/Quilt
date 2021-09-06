using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt
{
    public class Square : Shape
    {
        private double sides;
       
        public Square(string colorIn, double sideIn)
        {
            sides = sideIn;
            color = colorIn;
            shapeName = "Square";
        }
        public override double GetArea()
        {
            return sides * sides;
        }
    }
}
