using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    internal class Program
    {
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year to be checked :");
            int year=int.Parse(Console.ReadLine());

            if(IsLeapYear(year))
            {
                Console.WriteLine(year + " is a Leap year");
            }
            else
            {
                Console.WriteLine(year + " not a Leap year");
            }
        }
    }
}
