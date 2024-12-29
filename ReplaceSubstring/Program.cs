using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubstring
{
    internal class Program
    {
        public static string ReplaceSubstring (string input, string toReplace, string replacement)
        {
             return input.Replace (toReplace, replacement);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin: ");
            string orginal = Console.ReadLine();

            Console.WriteLine("Deyisdirilecek söz/simvol: ");
            string toReplace = Console.ReadLine();

            Console.WriteLine("Yeni söz/simvol:");
            string replacement = Console.ReadLine();

            string result = ReplaceSubstring (orginal, toReplace, replacement);

            Console.WriteLine($"Netice: {result}") ;

            Console.ReadKey();
        }
    }
}
