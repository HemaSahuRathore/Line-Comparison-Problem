namespace LineComparison_Program
{  /// <summary>
   /// UC4 : Refactor Code using Object Oriented Programming Concepts
   /// </summary>
    internal class Program
    {
        //Entrypoint of console app
        static void Main(string[] args)
        {
            Console.WriteLine("Please select from below options to perform a task: ");
            Console.Write("\n1.To Calculate length of a line \n2.To check equality of 2 lines \n3.To compare 2 lines    ");
            int options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1:
                    CalculateLineLength calLineLength = new CalculateLineLength();
                    double length = calLineLength.CalcLineLength();
                    Console.WriteLine("Length of line : " + length);
                    break;
                case 2:
                    CheckEquality checkEquality = new CheckEquality();
                    checkEquality.CheckEqualityOf2Line();
                    break;
                default:
                    Console.WriteLine("For line 1");
                    CalculateLineLength calLineLengthObj1 = new CalculateLineLength(); //Creating CalculateLineLength class object to cal length
                    double length1 = calLineLengthObj1.CalcLineLength(); //calling CalcLineLength() method of class and store value in length 1

                    CalculateLineLength calLineLengthObj2 = new CalculateLineLength();
                    Console.WriteLine("For line 1");
                    double length2 = calLineLengthObj2.CalcLineLength();

                    Compare2Lines compare2lines = new Compare2Lines();// created Compare2Lines class object
                    compare2lines.CompareTwoLines(length1, length2); //calling method to comp. 2 lines

                    break;

            }
        }
    }
}
 