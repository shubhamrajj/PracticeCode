using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            string s=Console.ReadLine();

            char[] arr=s.ToCharArray();

            Array.Sort(arr);
            Console.WriteLine(arr);
        }
    }
}
