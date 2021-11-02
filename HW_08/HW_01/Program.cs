using System;
using System.Text;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1a!2.3!!.. 4.!.?6 7! ..?";
            Console.WriteLine(input);
            int index = input.IndexOf('?');
            
            string left = input.Substring(0, index);
            string right = input.Substring(index);

            left = left.Replace("!", "");
            left = left.Replace(".", "");

            right = right.Replace(" ", "_");

            string result = left +right;
            Console.WriteLine(result);
        }
    }
}

