using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowelsandConsonants
{
    internal class Program
    {
        public static(int vowels, int consonants) CountVowelsandConsonants(string input)
        {
            int vowelCount = 0;
            int consonantsCount = 0;

            string vowels = "aeiouəöüı";

            input = input.ToLower();

            foreach(char c in input)
            {
                if(char.IsLetter(c))
                {
                    if(vowels.Contains(c))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantsCount++;
                    }
                }   
            }
           
            return (vowelCount, consonantsCount);
        }
        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string sentence = Console.ReadLine();

            var result = CountVowelsandConsonants(sentence);

            Console.WriteLine($"Saitler: {result.vowels}");
            Console.WriteLine($"Samitler: {result.consonants}");

            Console.ReadKey();
        }
    }
}
