using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    internal class Program
    {
        static bool IsAnagram(string s1,string s2)
        {
            char[] arr1= s1.ToCharArray();
            char[] arr2= s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            return new string(arr1) == new string(arr2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First String ");
            string n1=Console.ReadLine();
            Console.WriteLine("Enter the Seconde String ");
            string n2=Console.ReadLine();

            if (IsAnagram(n1, n2))
            {
                Console.WriteLine(n1+" and "+n2+" are Anagrams");
            }
            else
            {
                Console.WriteLine(n1 + " and " + " are not Anagrams");
            }
        }
    }
}
