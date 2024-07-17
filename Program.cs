using System;

namespace Ex._6._3_CSC205
{

    public class SquareRootCalculator
    {

        public static double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot compute the square root of a negative number");
            }

            double x0 = a / 2;
            double x1 = (x0 + a / x0) / 2;

            while (Math.Abs(x1 - x0) >= 0.0001)
            {
                x0 = x1;
                x1 = (x0 + a / x0) / 2;
            }

            return x1;

        }

        public static void Main()
        {
            double number = 9;
            double result = SquareRoot(number);
            Console.WriteLine("Square root of {0} is approximately {1}", number, result);
        }
    }
}
