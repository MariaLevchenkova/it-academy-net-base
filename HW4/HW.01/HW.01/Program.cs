using System;

namespace HW._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0, 5);
            }
            Console.WriteLine("Random array:");
            Print(a);

            int[] a1 = new int[5];
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("enter mumber");
                string s1 = Console.ReadLine();
                int i1 = int.Parse(s1);
                a1[i] = i1;
            }
            Console.WriteLine("Array from console:");
            Print(a1);

            //вывод суммы 2 ячеек
            int[] a2 = new int[5];
            a2[0] = a[0] + a1[0];
            Console.WriteLine("Sum:");

            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = a[i] + a1[i];
            }
            Print(a2);
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
