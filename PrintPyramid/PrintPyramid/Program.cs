using System;

class Program
{
    static void Main()
    {
        int pyramidSize = 5;
        char baseChar = 'A';

        PrintPyramid(pyramidSize, baseChar);
    }

    static void PrintPyramid(int size, char baseChar)
    {
        int totalChars = (2 * size) - 1;
        int midpoint = totalChars / 2;
        int charValue = (int)baseChar;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < totalChars; col++)
            {
                if (col >= midpoint - row && col <= midpoint + row)
                {
                    Console.Write((char)charValue);
                    charValue++;
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
