using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFrequency
{
    internal class Program
    {
        public static int FindCharacterFrequency(string input, char target)
        {
            int count = 0;

            foreach(char c in input)
            {
                if(c == target)
                {
                    count++;
                }
            }

            return count;
        }

       
        
        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string orginal = Console.ReadLine();

            Console.Write("Axtarilan simvol: ");
            char target = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int frequency = FindCharacterFrequency(orginal, target);

            Console.WriteLine($"\"{target}\" simvolu {frequency} defe tapildi.");

            Console.ReadKey();
        }
    }
}
