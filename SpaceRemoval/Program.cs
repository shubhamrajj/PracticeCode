using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRemoval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "  Hello,   world!  ";
            string strWithoutSpaces = "";

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c != ' ')
                {
                    strWithoutSpaces += c;
                }
            }

            Console.WriteLine($"Original string: \"{str}\"");
            Console.WriteLine($"String without spaces: \"{strWithoutSpaces}\"");
        }
    }
}
