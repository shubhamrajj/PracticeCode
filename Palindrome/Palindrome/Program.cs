﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Func1
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            string _inputstr, _reversestr = string.Empty;
            Console.Write("Enter a string : ");
            _inputstr = Console.ReadLine();
            if (_inputstr != null)
            {
                for (int i = _inputstr.Length - 1; i >= 0; i--)
                {
                    _reversestr += _inputstr[i].ToString();
                }
                if (_reversestr == _inputstr)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
            }
            Console.ReadLine();
        }
    }
}