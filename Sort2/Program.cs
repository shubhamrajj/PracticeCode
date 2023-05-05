using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 2, 4, 5, 1, 6, 7, 7 };

            Console.Write("Non-repeating numbers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isRepeating = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        isRepeating = true;
                        break;
                    }
                }

                if (!isRepeating)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
