using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveWhitespace
{
    internal class Program
    {
        public static string WhitespaceRemove(string input)
        {
            return input.Replace(" ", "");
        }
        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string orginal = Console.ReadLine();

            string result = WhitespaceRemove(orginal);

            Console.WriteLine($"Netice: {result}");

            Console.ReadKey();
        }
    }
}
