using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            int numberOfDigits = 0;

            while (number != 0)
            {
                number /= 10;
                numberOfDigits++;
            }

            Console.WriteLine($"The number has {numberOfDigits} digits.");
            Console.ReadLine();
        }
    }
}
