using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 10000; 

            Console.Write($"Strong numbers up to {limit}: ");

            for (int number = 1; number <= limit; number++)
            {
                int factorialSum = 0;
                int n = number;

                while (n != 0)
                {
                    int digit = n % 10;
                    factorialSum += Factorial(digit);
                    n /= 10;
                }
                if (factorialSum == number)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.ReadLine();
        }
        static int Factorial(int number)
        {
            int result = 1;
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }
            return result;

        }
    }
}
