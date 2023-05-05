using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mergibg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];

            Console.WriteLine("Enter elements in Array 1 :");
            for(int i=0; i<arr1.Length; i++)
            {
                arr1[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements in Array 2 :");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] arr3 = new int[arr1.Length+arr2.Length];

            for(int i= 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length+1] = arr2[i];
            }

            for(int i=0;i<arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]); 
            }
        }
    }
}
