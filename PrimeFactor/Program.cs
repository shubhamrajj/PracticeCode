using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int n=int.Parse(Console.ReadLine());

            Console.WriteLine("The Prime Factors of the number are :");
            for(int i=2; i <= n; i++)
            {
                while(n%i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
            }

        }
    }
}
