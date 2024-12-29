using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    internal class Program
    {
        public static bool IsPalindrome (string input)
        {
            string palindrom = input.ToLower().Replace(" ", "");

            char[] charArray = palindrom.ToCharArray ();
            Array.Reverse (charArray);

            string reversed = new string (charArray);

            return palindrom == reversed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin:");
            string orginal = Console.ReadLine ();
            if (IsPalindrome(orginal))
            {
                Console.WriteLine($"\"{orginal}\"palindromdur.");
            }
            else
            {
                Console.WriteLine($"\" {orginal}\"palindrom deyil.");
            }

            Console.ReadKey();

        }
    }
}
