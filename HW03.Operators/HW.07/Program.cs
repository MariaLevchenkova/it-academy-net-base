using System;

namespace HW._03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter you year of birth");
            string s1 = Console.ReadLine();
            int birthYear = int.Parse(s1);

            Console.WriteLine("enter you NUMBER month of birth");
            string s2 = Console.ReadLine();
            int birthMonth = int.Parse(s2);

            Console.WriteLine( "enter year now");
            string s3 = Console.ReadLine();
            int currentYear = int.Parse(s3);

            Console.WriteLine( "enter NUMBER month now");
            string s4 = Console.ReadLine();
            int currentMonth = int.Parse(s4);

            if (birthMonth <= currentMonth)
            {
                int i5 = currentYear - birthYear;
                Console.WriteLine(i5);
            }
            else
            {
                int i6 = currentYear -birthYear-1;
                Console.WriteLine(i6);
            }
        }
    }
}
