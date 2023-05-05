using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[10];
            Console.WriteLine("Enter 10 numbers :");
            for(int i=0; i<num.Length; i++)
            {
                num[i]=int.Parse(Console.ReadLine());
            }
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for(int i=0 ; i<num.Length ; i++)
            {
                if (num[i] > largest)
                {
                    secondLargest=largest;
                    largest = num[i];
                }
                else if (num[i] > secondLargest && num[i] != largest)
                {
                    secondLargest= num[i];
                }
            }
            Console.WriteLine("The Second Largest number is : "+secondLargest);
        }
    }
}
