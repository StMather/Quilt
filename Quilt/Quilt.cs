using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt
{
    public class Quilt
    {
        private List<Shape> record;
        public Quilt()
        {
            record = new List<Shape>();
        }
        public bool addShape(Shape shapeIn)
        {
            try
            {
                Console.WriteLine($"{shapeIn.ToString()} was added!");
                record.Add(shapeIn);
                return true;
            }
            catch
            {
                Console.WriteLine("Failed to add!");

                return false;
            }
            
        }
        public bool removeShape(int intIn)
        {
            if (intIn < record.Count)
            {
                record.RemoveAt(intIn - 1);
                return true;
            }
            else
            {

                return false;
            }
        }
        public void ShowQuilt()
        {
            if (record.Count > 0)
            {
                foreach (Shape x in record)
                {

                    Console.Write($"{x.ToString()} | ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nothing in quilt");
            }
        }
    }
}
