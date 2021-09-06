using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt
{
    
    public class Menu
    {
        private string mainMenu = "1. See Quilt \n2. Add Square\n3. Add Rectangle\n4. Add Triangle\n5. Quit";
        private Quilt myQuilt = new Quilt();
        public void MainMenu()
        {
            Console.WriteLine(mainMenu);
            Console.Write("Choose:");
            string choiceString = Console.ReadLine();
            int choice = 0;
            while(int.TryParse(choiceString, out choice) && choice < 5)
            {
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        myQuilt.ShowQuilt();
                        break;
                    case 2:
                        SquareMenu();
                        break;
                    case 3:
                        RectangleMenu();
                        break;
                    case 4:
                        TriangleMenu();
                        break;
                }
                Console.WriteLine(mainMenu);
                Console.Write("Choose:");
                choiceString = Console.ReadLine();
            }
        }
        private void SquareMenu()
        {
            double sides;
            string squareColor;
            Console.Write("Please enter a color for your Square:");
            squareColor = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter the side length:");
            sides = GetLengthDouble();
            myQuilt.addShape(new Square(squareColor, sides));
        }
        private void RectangleMenu()
        {
            double side1;
            double side2;
            string rectangleColor;
            Console.Write("Please enter a color for your Rectangle:");
            rectangleColor = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter the hight:");
            side1 = GetLengthDouble();
            Console.Write("Please enter the length:");
            side2 = GetLengthDouble();
            myQuilt.addShape(new Rectangle(rectangleColor, side1, side2));
        }
        private void TriangleMenu()
        {
            double side1;
            double side2;
            double side3;
            string triangleColor;
            Console.Write("Please enter a color for your Triangle:");
            triangleColor = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter the length of the first side:");
            side1 = GetLengthDouble();
            Console.Write("Please enter the length of the second side:");
            side2 = GetLengthDouble();
            Console.Write("Please enter the length of the third side:");
            side3 = GetLengthDouble();
            myQuilt.addShape(new Triangle(triangleColor, side1, side2, side3));
        }
        private double GetLengthDouble()
        {
            double side;
            if (double.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Length not a number please try again!");
                Console.Write("Length:");
                GetLengthDouble();
            }
            return side;
        }
    }
}
