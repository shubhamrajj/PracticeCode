using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MathFunc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            Console.WriteLine("Enter a set of numbers :");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int even = 0, odd = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]%2==0)
                {
                    even += arr[i];
                }
                else
                {
                    odd += arr[i];
                }
            }
            Console.WriteLine("The sum of even numbers are :" + even);
            Console.WriteLine("The sum of odd numbers are :" + odd);
        }
    }
}
