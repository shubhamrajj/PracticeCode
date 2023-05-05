using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num=new int[10];
            Console.WriteLine("Enter 10 numbers :");
            for(int i=0;i<num.Length; i++)
            {
                num[i]=int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Even Numbers are :");
            for(int i=0 ; i<num.Length ; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            Console.WriteLine("Odd Numbers are :");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
