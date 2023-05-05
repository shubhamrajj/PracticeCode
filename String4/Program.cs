using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be printed in ascending order :");
            string s1=Console.ReadLine();

            char[] arr =s1.ToCharArray();

            Array.Sort(arr);

            Console.WriteLine(arr);


        }
    }
}
