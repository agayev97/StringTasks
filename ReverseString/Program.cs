using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        public static string ReverseString(string input)
        {
            char[] charArry = input.ToCharArray();

            Array.Reverse(charArry);

            return new string(charArry);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Stringi daxil edin:");

            string orginal = Console.ReadLine();

            string reversed = ReverseString(orginal);

            Console.WriteLine($"Reversed: {reversed}");
            

            Console.ReadKey();

        }                                     
    }
}
