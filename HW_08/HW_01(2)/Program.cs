using System;
using System.Text;

namespace HW_01_2_
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

            StringBuilder leftnew = new StringBuilder(left);
            StringBuilder rightnew = new StringBuilder(right);
            
            leftnew.Replace("!", "");
            leftnew.Replace(".", "");
            rightnew.Replace(" ", "_");
            
             leftnew.Append(rightnew);

            Console.WriteLine(leftnew);
        }
    }
}
