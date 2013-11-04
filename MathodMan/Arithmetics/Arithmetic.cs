using MathodMan.Internals;
using System;

namespace MathodMan.Arithmetics
{
    public class Arithmetic
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return !IsEven(number);
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            Sanitize.EnsureTwoNumbersAreNotBothZero(a, b);

            if (a == 0 || b == 0)
            {
                return Math.Max(Math.Abs(a), Math.Abs(b));
            }

            int nominator = a;
            int denominator = b;
            int leftOver;

            do
            {
                leftOver = nominator % denominator;

                nominator = denominator;
                denominator = leftOver;
            } while (leftOver != 0);

            return nominator;
        }

        public static int LeastCommonMultiple(int a, int b)
        {
            Sanitize.EnsureTwoNumbersAreNotBothZero(a, b);

            if (a == 0 || b == 0)
            {
                return Math.Max(Math.Abs(a), Math.Abs(b));
            }

            return Math.Abs(a * b) / GreatestCommonDivisor(a, b);
        }
    }
}
