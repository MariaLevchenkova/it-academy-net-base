using System;

namespace HW._06
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo r = Console.ReadKey();
                if (r.Key == ConsoleKey.W)
                {
                    Console.WriteLine("up");
                }
                else if (r.Key == ConsoleKey.A)
                {
                    Console.WriteLine("left");
                }
                else if (r.Key == ConsoleKey.D)
                {
                    Console.WriteLine("right");
                }
                else if (r.Key == ConsoleKey.S)
                {
                    Console.WriteLine("down");
                }
                else
                {
                    Console.WriteLine("stop");
                }
            }
        }
    }
}
