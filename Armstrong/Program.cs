using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 1000;

            Console.Write($"Armstrong numbers up to {limit}: ");

            for (int number = 1; number <= limit; number++)
            {
                int sumOfPowers = 0;
                int n = number;
                int numberOfDigits = (int)Math.Floor(Math.Log10(number) + 1);

                while (n != 0)
                {
                    int digit = n % 10;
                    sumOfPowers += (int)Math.Pow(digit, numberOfDigits);
                    n /= 10;
                }

                if (sumOfPowers == number)
                {
                    Console.Write($"{number} ");
                }
            }

        }
    }
}
