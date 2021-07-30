using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Line line = new Line();
            line.TwoLinesComparison();
=======
            Line line1 = new Line(2, 4, 8, 16);
            Line line2 = new Line(8, 16, 32 , 64);

            double lengthOfLine1 = line1.Calculate();
            Console.WriteLine("Length of the Line 1 is:" + lengthOfLine1);
            double lengthOfLine2 = line2.Calculate();
            Console.WriteLine("Length of the Line 2 is:" + lengthOfLine2);


            if (lengthOfLine1.CompareTo(lengthOfLine2) > 0)
                Console.WriteLine("Length of Line 1 is Greater than Line 2 ");
            else
            {
                if (lengthOfLine1.CompareTo(lengthOfLine2) < 0)
                    Console.WriteLine("Length of Line 2 is Greater than line 1");
                else
                    Console.WriteLine("Length of Line 1 equal to Line 2 ");
            }
>>>>>>> UC4_LinesComparisonUsingMethod
        }
    }
}
