using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_Program
{
    internal class Compare2Lines
    {
        public void CompareTwoLines(double length1, double length2 ) 
        {
             //Selection statement to compare length of 2 line
                int value = length1.CompareTo(length2); //using CompareTo method to compare length of 2 lines
                if (value < 0)
                    Console.WriteLine("Length of Line 1 is smaller than Line 2");
                else if (value == 0)
                    Console.WriteLine("Length of Line 1 is equal to Line 2");
                else
                    Console.WriteLine("Length of Line 1 is greater than Line 2");
        }
    }
}

    

