using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    internal class Program
    {
        static string RemoveChar(string s1,string s2)
        {
            string newString = "";
            foreach(char c in s1)
            {
                if (!s2.Contains(c.ToString()))
                {
                    newString += c;
                }
            }
            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First String ");
            string s1=Console.ReadLine();
            Console.WriteLine("Enter the Second String ");
            string s2=Console.ReadLine();
            string nString=RemoveChar(s1,s2);
            Console.WriteLine(nString);
        }
    }
}
