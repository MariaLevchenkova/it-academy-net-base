using System;

namespace HW02.var2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine("enter mumber");
                string s1 = Console.ReadLine();
                int i1 = int.Parse(s1);
                a[i] = i1;
            }
            Print(a);

            Console.WriteLine("enter  new number ");
            string s2 = Console.ReadLine();
            int number = int.Parse(s2);

            Console.WriteLine("enter position new number");
            string s3 = Console.ReadLine();
            int index = int.Parse(s3);

            int[] b = new int[5];
            for (int i = 0; i <= index - 1; i++)
            {
                b[i] = a[i];
            }

            b[index] = number;
            for (int i = index + 1; i < b.Length; i++)
            {
                b[i] = a[i - 1];
            }
            Print(b);
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
