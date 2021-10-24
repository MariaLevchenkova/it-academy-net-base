using System;

namespace HW._05.Task4
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine( "enter mumber fron 1 before 100");
            int number = int.Parse(Console.ReadLine());
          
            for (int row = 0; row < number; row++)
            {
                int a = row + 1;
                Console.Write(new string(' ', row));

                for (int i = 0; i < number - row; i++)
                {
                    Console.Write(a % 10 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
