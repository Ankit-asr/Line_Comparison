using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line(0, 2, 4, 8);
            Line line2 = new Line(8, 10, 12, 14);

            line1.Calculate();
            line2.Calculate();
            if (line1.Equals(line2))
                Console.WriteLine("Both lines are of same size");
            else
                Console.WriteLine("Both lines are of different sizes");
        }
    }
}
