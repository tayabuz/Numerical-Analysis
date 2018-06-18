using System;

namespace Numerical_Analysis
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(NumAnalysis.BisectionMethod(F, 0, 2 , 0.02));
            Console.WriteLine(NumAnalysis.GoldenSectionSearch(F, 0, 2, 0.02));
            Console.ReadLine();
        }

        static double F(double x)
        {
            return 2 * x * x + x - 9.0;
        }
    }
}
