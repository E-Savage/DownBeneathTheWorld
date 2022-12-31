using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownBeneathTheWorld.ConsoleWriter
{
    public class ConsoleWriter
    {
        public void PrintTitle(string s)
        {
            s = s.Trim();
            for (int i = 0; i <= s.Length + 1; i++)
            {
                Console.Write("~");
            }  

            Console.WriteLine($"\n|{s}|");

            for (int i = 0; i <= s.Length + 1; i++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }

        public void PrintLocationBanner(string s)
        {
            string locationString = "Location: ";
            locationString += s.Trim();  
            for (int i = 0; i <= locationString.Length + 1; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine($"\n#{locationString}#");

            for (int i = 0; i <= locationString.Length + 1; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }
    }
}
