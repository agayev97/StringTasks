using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    internal class Program
    {
        public static int CountWords (string word)
        {
            string[] words = word.Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin:");
            string sentence = Console.ReadLine ();
            int wordCount = CountWords (sentence);

            Console.WriteLine($"Sözlerin sayı: {wordCount}");

            Console.ReadKey();

        }
    }
}
