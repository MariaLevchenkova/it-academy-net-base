using System;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            Console.WriteLine(sentence);

            string result1 = RemoveLongestWord(sentence);
            Console.WriteLine(result1);

            string result2 = ReplaceWords(sentence);
            Console.WriteLine(result2);

            int[] result3 = GetLettersAndPunctuationCount(sentence);
            Console.WriteLine(result3[0]);
            Console.WriteLine(result3[1]);

            string[] result = SortWords(sentence);

            foreach(var word in result)
            {
                Console.WriteLine(word);
            }
        }

        static string RemoveLongestWord(string sentence)
        {
            string[] words = sentence.Split(" ");
            string maxword = words[0];
            
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > maxword.Length)
                {
                    maxword = words[i];
                }
            }
            string result = sentence.Remove(sentence.IndexOf(maxword), maxword.Length);
            return result;
        }

        static string ReplaceWords(string sentence)
        {
            string[] words = sentence.Split(" ");

            int maxIndex = 0;
            string maxword = words[maxIndex];
            
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > maxword.Length)
                {
                    maxIndex = i;
                    maxword = words[i];
                }
            }

            int minIndex = 0;
            string minword = words[minIndex];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length < minword.Length)
                {
                    minIndex = i;
                    minword = words[i];
                }
            }

            Console.WriteLine($"max = {maxword}");
            Console.WriteLine($"min = {minword}");

            string temp = words[maxIndex];
            words[maxIndex] = words[minIndex];
            words[minIndex] = temp;

            string result = string.Join(' ', words);
            return result;
        }

        static int[] GetLettersAndPunctuationCount(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            int letter = 0;
            int punctuation = 0;
            
            for (int i = 0; i <sentence.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    letter = letter + 1;
                }
                if (char.IsPunctuation(chars[i]))
                {
                    punctuation = punctuation + 1;
                }
            }

            int [] result =  new int [] {letter, punctuation};
            return result;
        }

        static string[] SortWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            int[] wordLengths = new int[words.Length];
            for(int i = 0; i < words.Length; i++){
                wordLengths[i] = words[i].Length;
            }

            Array.Sort(wordLengths, words); // sort by asc
            Array.Reverse(words);

            return words;
        }   
    }
}
