using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string s1=Console.ReadLine();

            char[] arr=s1.ToCharArray();

            int n = 0;
            foreach(char c in arr)
            {
                if (c == 'a'|| c=='A')
                {
                    n++;
                }
            }
            Console.WriteLine("a is present " + n + " times");
        }
    }
}
