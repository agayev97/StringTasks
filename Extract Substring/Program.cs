using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Substring
{
    internal class Program
    {
        public static string ExtractSubstring(string input, int startIndex, int length)
        {
            return input.Substring(startIndex, length);
        }
        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string orginal = Console.ReadLine();

            Console.Write("Baslama indeksini daxil edin: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Uzunluğu daxil edin: ");
            int length = int.Parse(Console.ReadLine());

            try
            {
                string result = ExtractSubstring(orginal, startIndex, length);
                Console.WriteLine($"Netice: {result}");

            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Xeta: Başlama indeksi ve ya uzunluq düzgün deyil.");
            }

            Console.ReadKey();
        }
    }
}
