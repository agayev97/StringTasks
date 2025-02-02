using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a - ni daxil edin:");

            int a = int.Parse(Console.ReadLine());

            int faktorial = Faktorial(a);
            Console.WriteLine($"{a}! = {faktorial}");

            Console.ReadKey();
        } 

       static int Faktorial(int x)
        {
            if (x == 0) return 1;
            return x * Faktorial(x - 1);
        }
    }
}
