using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Func1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Console.WriteLine("Enter 10 numbers :");
            for(int i=0; i<10; i++)
            {
                n[i]=int.Parse(Console.ReadLine());
            }
            Array.Sort(n);
            double sum = 0;
            Console.WriteLine("The average of the numbers are");
            for(int i=0; i<10;i++)
            {
                
                sum += n[i];

            }
            Console.WriteLine(sum/(n.Length));
            
        }
    }
}
