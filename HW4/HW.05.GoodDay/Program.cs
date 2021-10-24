using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            string greetings = Greetings(hour);
            Console.WriteLine(greetings);
        }

        static string Greetings(int hour) => hour switch
    {
        (>=9) and (< 12) => "Good morning, guys",
        (>=12) and (<15)  => "Good day,guys",
        (>=15) and (<22) => "Good evening,gues",
        _ => "Good night, gues",
    };
    }
}
