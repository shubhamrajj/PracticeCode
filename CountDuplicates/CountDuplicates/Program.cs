using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Hello World";

        Dictionary<char, int> duplicates = CountDuplicates(input);

        Console.WriteLine("Duplicates in the input string:");

        foreach (var kvp in duplicates)
        {
            if (kvp.Value > 1)
            {
                Console.WriteLine($"Character '{kvp.Key}': Count = {kvp.Value}");
            }
        }
    }

    static Dictionary<char, int> CountDuplicates(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        return charCount;
    }
}
