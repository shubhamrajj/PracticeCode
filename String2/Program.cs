using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        static void Permute(string pre, string rem)
        {
            int len = rem.Length;
            if (len == 0)
            {
                Console.WriteLine(pre);
            }
            else
            {
                for(int i = 0; i < len; i++)
                {
                    string nPre = pre + rem[i];
                    string nRem=rem.Substring(0,i)+rem.Substring(i+1);
                    Permute(nPre, nRem);
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input=Console.ReadLine();
            Console.WriteLine("All the Permutation of " + input + " are : ");
            Permute("", input);
        }
    }
}
