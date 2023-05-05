using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string value :");
            string str =Console.ReadLine();
            int length = 0;

            foreach (char c in str)
            {
                if (c == '\0')
                {
                    break;
                }
                length++;
            }

            Console.WriteLine($"The length of the string \"{str}\" is {length}.");
            Console.ReadLine();
        }
    }
}
