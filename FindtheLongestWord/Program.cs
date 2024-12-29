using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindtheLongestWord
{
    internal class Program
    {
        public static string FindLongestWord(string input)
        {
            string longestWord = input
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(x => x.Length)
                .FirstOrDefault();

            return longestWord;
        }
        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string sentence = Console.ReadLine();

            string longest = FindLongestWord (sentence);

            Console.WriteLine($"En uzun soz: {longest}");

            Console.ReadKey();
        }
    }
}
