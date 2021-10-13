using System;

namespace HW._09.Cal
{
    class Calculator
    {
        public static int Sum(string first, string second)
        {
            int i1 = Convert.ToInt32(first);
            int i2 = Convert.ToInt32(second);
            int i3 = i1 + i2;

            return i3;
        }

        // subtraction
        public static int Subtraction(string first, string second)
            {
            int i1 = Convert.ToInt32(first);
            int i2 = Convert.ToInt32(second);
            int i3 = i1 - i2;

            return i3;
            }
        // multiply
        public static int Multiply(string first, string second)
        {
            int i1 = Convert.ToInt32(first);
            int i2 = Convert.ToInt32(second);
            int i3 = i1 * i2;

            return i3;

        }

        // division
        public static int Division(string first, string second)
        {
            int i1 = int.Parse(first);
            int i2 = int.Parse(second);
            int i3 = i1 / i2;

            return i3;
        }
        // remainder
        public static int Remainder(string first, string second)
        {
            int i1 = int.Parse(first);
            int i2 = int.Parse(second);
            int i3 = i1 % i2;

            return i3;
        }

        // CirleArea
        public static double CirleArea(string first)
        {
            int i1 = int.Parse(first);
            double i2 = Math.PI*i1*i1;

            return i2;
        }
    }
}
