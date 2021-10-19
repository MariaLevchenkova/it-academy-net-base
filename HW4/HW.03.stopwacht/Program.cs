using System;

namespace HW._03.Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] a = new long [100_000_000];
            Random random = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0, 100000000);
            }
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            Array.Reverse(a);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            stopWatch.Restart();
            Reverse(a);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }

        static void Reverse(long[] a)
        {
            for (int i = 0; i <= a.Length / 2; i++)
            {
                long c = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = c;
            }
        }
    }
}
