using System;

class Program
{
    static void Main()
    {
        string input = "abcdefghij";
        int parts = 3;

        string[] dividedParts = DivideString(input, parts);

        Console.WriteLine($"Dividing '{input}' into {parts} equal parts:");
        for (int i = 0; i < dividedParts.Length; i++)
        {
            Console.WriteLine($"Part {i + 1}: {dividedParts[i]}");
        }
    }

    static string[] DivideString(string input, int parts)
    {
        int inputLength = input.Length;
        int partSize = inputLength / parts;

        // If the input length is not evenly divisible by parts, adjust the part size
        if (inputLength % parts != 0)
        {
            partSize++;
        }

        string[] dividedParts = new string[parts];

        for (int i = 0; i < parts; i++)
        {
            int startIndex = i * partSize;
            int endIndex = Math.Min(startIndex + partSize, inputLength);

            dividedParts[i] = input.Substring(startIndex, endIndex - startIndex);
        }

        return dividedParts;
    }
}
