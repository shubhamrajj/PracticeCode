using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Range :");
            int start = int.Parse(Console.ReadLine()); 
            int end = int.Parse(Console.ReadLine()); ; 

            Console.Write("Prime numbers between "+start+" and "+end+" : ");

            for (int number = start; number <= end; number++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && number > 1)
                {
                    Console.Write(number);
                }

            }
        }
    }
}
