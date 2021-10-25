using System;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a line from the poem by separating lines ;");
            string input = Console.ReadLine();

            string[] sentences = input.Split(new char[] { ';' });

            foreach (string sentence in sentences)
            {
                string newSentence= sentence.Replace('o', 'a').Replace('O', 'A');
                Console.WriteLine(newSentence);
            }
        }
    }
}
