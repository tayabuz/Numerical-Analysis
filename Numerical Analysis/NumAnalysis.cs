using System;

namespace Numerical_Analysis
{
    public class NumAnalysis
    {
        public delegate double Function(double x);
        public static double BisectionMethod(Function f, double a, double b, double epsilon)
        {
            double x1 = a;
            double x2 = b;
            double fb = f(b);
            while (Math.Abs(x2 - x1) > epsilon)
            {
                double midpt = 0.5 * (x1 + x2);
                if (fb * f(midpt) > 0)
                    x2 = midpt;
                else
                    x1 = midpt;
            }
            return x2 - (x2 - x1) * f(x2) / (f(x2) - f(x1));
        }

        public static double GoldenSectionSearch(Function f, double a, double b, double epsilon)
        {
            double PHI = (1 + Math.Sqrt(5)) / 2;
            double x1, x2;
            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;
                if (f(x1) <= f(x2))
                    a = x1;
                else
                    b = x2;
                if (Math.Abs(b - a) < epsilon)
                    break;
            }
            return (a + b) / 2;
        }

    }
}
