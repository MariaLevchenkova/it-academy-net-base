using System;

namespace HW._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static void Sum()
        {
            int i1, i2, i3;

            // i1
            Console.WriteLine("please enter number");
            string s1 = Console.ReadLine();

            while (!int.TryParse(s1, out i1))
            {
                Console.WriteLine("this is not a number, please try again");
                s1 = Console.ReadLine();
            }

            // i2
            Console.WriteLine("please enter number 2");
            string s2 = Console.ReadLine();

            while (!int.TryParse(s2, out i2))
            {
                Console.WriteLine("this is not a number, please try again");
                s2 = Console.ReadLine();
            }            

            // o
            Console.WriteLine("please enter operation +/-");
            string o = Console.ReadLine();

            // i3
            Console.WriteLine("please enter result");
            string s3 = Console.ReadLine();

            while (!int.TryParse(s3, out i3))
            {
                Console.WriteLine("this is not a number, please try again");
                s3 = Console.ReadLine();
            }

            int sum =default;
            if (o == "+")
            {
                sum = i1 + i2;
            }
            else if (o=="-") 
            {
                 sum = i1 - i2;
            }
            else
            {
                Console.WriteLine("this operation is not supported");
                return;
            }
            if (i3 == sum)
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("wrong");
                if (i3 > sum)
                {
                    Console.WriteLine("should be less");
                }
                else
                {
                    Console.WriteLine("should be more");

                }
            }

        }
    }
}

