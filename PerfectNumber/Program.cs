using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 10000; 

            Console.Write($"Perfect numbers up to {limit}: ");

            for (int number = 1; number <= limit; number++)
            {
                int sumOfDivisors = 0;

                for (int divisor = 1; divisor < number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        sumOfDivisors += divisor;
                    }
                }
                if (sumOfDivisors == number)
                {
                    Console.Write($"{number} ");
                }
            }

        }
    }
}
