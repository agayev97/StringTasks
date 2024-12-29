using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleCaseConverter
{
    internal class Program
    {
        public static string ToTitleCase(string text)
        {
            string[] words = text.Split(' ');

            for(int i =0;  i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            return string.Join(" ", words);
        }


        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string sentence = Console.ReadLine();

            string result = ToTitleCase(sentence);

            Console.WriteLine($"Title Case: {result}");

            Console.ReadKey();

        }
    }
}
