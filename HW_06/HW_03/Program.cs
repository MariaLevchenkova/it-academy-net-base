using System;

namespace HW_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "gdfgdf234dg54gf+23oP42";
            Char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    input = input.Replace(chars[i].ToString(), "");
                }
            }

            Console.WriteLine(input);

            for (int i = 0; i <input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        {
                            string left = input.Substring(0, i);
                            string right = input.Substring(i + 1);
                            int result = int.Parse(left) + int.Parse(right);
                            Console.WriteLine(result);
                        }
                        break;
                    case '-':
                        {
                            string left = input.Substring(0, i);
                            string right = input.Substring(i + 1);
                            int result = int.Parse(left) - int.Parse(right);
                            Console.WriteLine(result);
                        }
                        break;
                    case '*':
                        {
                            string left = input.Substring(0, i);
                            string right = input.Substring(i + 1);
                            int result = int.Parse(left) * int.Parse(right);
                            Console.WriteLine(result);
                        }
                        break;
                    case '/':
                        {
                            string left = input.Substring(0, i);
                            string right = input.Substring(i + 1);
                            int result = int.Parse(left) / int.Parse(right);
                            Console.WriteLine(result);
                        }
                        break;
                }
            }
        }
    }
}
