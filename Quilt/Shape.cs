using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt
{
    public abstract class Shape 
    {
        protected string color;
        protected string shapeName;

        public abstract double GetArea();
        public override string ToString()
        {
            return ($"{color} {shapeName} with area of {GetArea()}");
        }
        //public abstract void SetDimentions();
    }
}
