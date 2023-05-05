using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            Console.WriteLine("Enter random 10 numbers :");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("The Smallest Number is : " + arr[0]);
            Console.WriteLine("The Greatest Number is : " + arr[arr.Length-1]);
        }
    }
}
