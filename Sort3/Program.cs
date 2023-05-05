using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[10];
            Console.WriteLine("Enten the numbers to be sorted");
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            // Perform a bubble sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            // Print the sorted array
            Console.Write("Sorted array: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}
