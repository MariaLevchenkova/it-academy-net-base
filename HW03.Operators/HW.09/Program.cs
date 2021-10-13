using System;

namespace HW._09.Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum
            Console.WriteLine("Enter numder 1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter numder2");
            string s2 = Console.ReadLine();

            int result = Calculator.Sum(s1, s2);

            Console.WriteLine("sum:");
            Console.WriteLine(result);

            //Subtraction
            Console.WriteLine("Enter numder 1");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter numder2");
            s2 = Console.ReadLine();

            result = Calculator.Subtraction(s1, s2);

            Console.WriteLine("Subtraction:");
            Console.WriteLine(result);

            //Multiply
            Console.WriteLine("Enter numder 1");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter numder2");
            s2 = Console.ReadLine();

            result = Calculator.Multiply(s1, s2);

            Console.WriteLine("Multiply:");
            Console.WriteLine(result);

            //Division
            Console.WriteLine("Enter numder 1");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter numder2");
            s2 = Console.ReadLine();

            result = Calculator.Division(s1, s2);

            Console.WriteLine("Division:");
            Console.WriteLine(result);

            // remainder
            Console.WriteLine("Enter numder 1");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter numder2");
            s2 = Console.ReadLine();

            result = Calculator.Remainder(s1, s2);

            Console.WriteLine("Remainder:");
            Console.WriteLine(result);

            //CirleArea
            Console.WriteLine("Enter numder 1");
            s1 = Console.ReadLine();

            double d = Calculator.CirleArea(s1);

            Console.WriteLine("CirleArea:");
            Console.WriteLine(d);

        }
    }
}
