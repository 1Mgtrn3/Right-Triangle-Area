using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangleLib
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            do
            {
                triangle t = input();



                TriangleChecker TC = new TriangleChecker(t);
                if (TC.IsValid())
                {

                    Console.WriteLine("The area of your triangle is " + t.GetArea().ToString());
                    Console.ReadKey();
                    done = true;
                }
                else
                {
                    Console.WriteLine("This is not the right triangle. Try again");

                }
            } while (done == false);
            



        }

        static triangle input()
        {
            Console.WriteLine("Enter the sides of your right triangle. Use Enter Key to split them.");
            double FirstSide;
            string line1 = Console.ReadLine();
            while (!Double.TryParse(line1, out FirstSide))
            {
                Console.WriteLine("Not a valid number, try again.");

                line1 = Console.ReadLine();
            }

            double SecondSide;
            string line2 = Console.ReadLine();
            while (!Double.TryParse(line2, out SecondSide))
            {
                Console.WriteLine("Not a valid number, try again.");

                line2 = Console.ReadLine();
            }

            double ThirdSide;
            string line3 = Console.ReadLine();
            while (!Double.TryParse(line3, out ThirdSide))
            {
                Console.WriteLine("Not a valid number, try again.");

                line3 = Console.ReadLine();
            }
            return new triangle(FirstSide, SecondSide, ThirdSide);
        }
    }
}
