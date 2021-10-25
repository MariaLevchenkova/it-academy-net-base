using System;
using System.IO;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("c:\\Temp\\FindMe.txt");

            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsControl(text[i]))
                {
                    string hex = ((int)text[i]).ToString("X");
                    Console.WriteLine($"Position: {i}, Char: {text[i]}, hex: {hex}");
                    count++;
                }
            }

            Console.WriteLine("Total count: " + count);
        }
    }
}
