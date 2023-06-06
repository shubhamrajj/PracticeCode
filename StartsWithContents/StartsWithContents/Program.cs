using System;

class Program
{
    static void Main()
    {
        string mainString = "Hello World";
        string startString = "Hello";

        bool startsWithContents = StartsWithContents(mainString, startString);

        Console.WriteLine("Does the main string start with the contents of the start string? " + startsWithContents);
    }

    static bool StartsWithContents(string mainString, string startString)
    {
        if (mainString.Length < startString.Length)
        {
            return false;
        }

        for (int i = 0; i < startString.Length; i++)
        {
            if (mainString[i] != startString[i])
            {
                return false;
            }
        }

        return true;
    }
}
