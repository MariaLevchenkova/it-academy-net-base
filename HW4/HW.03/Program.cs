using System;

namespace HW._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter please numeric string");
            string str = Console.ReadLine();
            char[] a = str.ToCharArray();

            for (int i = 0; i <= a.Length / 2; i++)
            {
                char c = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i]= c;
            }
            Console.WriteLine( new string(a));
        }
    }
}