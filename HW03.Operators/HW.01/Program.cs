using System;

namespace HW._01._
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static void Sum()
        {
            int i1, i2;

            Console.WriteLine("please enter number");
            string s1 = Console.ReadLine();

            while (!int.TryParse(s1, out i1))
            {
                Console.WriteLine("this is not a number, please try again");
                s1 = Console.ReadLine();
            }

            Console.WriteLine("please enter number 2");
            string s2 = Console.ReadLine();

            while (!int.TryParse(s2, out i2))
            {
                Console.WriteLine("this is not a number, please try again");
                s2 = Console.ReadLine();
            }

            int i3 = i1 + i2;
            Console.WriteLine(i3);
            
        }
    }
}
