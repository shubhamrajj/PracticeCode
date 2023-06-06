using System;

class Program
{
    static void Main()
    {
        string input = "HelloWorld";

        bool result = CheckFirstTwoCharacters(input);

        if (result)
        {
            Console.WriteLine("The first two characters are present at the end of the string.");
        }
        else
        {
            Console.WriteLine("The first two characters are not present at the end of the string.");
        }
    }

    static bool CheckFirstTwoCharacters(string input)
    {
        if (input.Length < 2)
        {
            return false;
        }

        string firstTwoCharacters = input.Substring(0, 2);
        string lastTwoCharacters = input.Substring(input.Length - 2);

        return firstTwoCharacters.Equals(lastTwoCharacters);
    }
}
