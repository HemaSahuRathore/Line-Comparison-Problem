using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_Program
{
    internal class CalculateLineLength
    {
        public double CalcLineLength()
        {
            double length;

            //Taking input for the Endpoints of Line 
            Console.WriteLine("Enter the Start(x1, y1) and End-point(x2,y2) co-ordinates of Line: ");
            Console.Write("x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            return length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2))); //calculation

        }
    }
}
