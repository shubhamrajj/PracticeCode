using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        PrintDiamondPattern(rows);
    }

    static void PrintDiamondPattern(int rows)
    {
        int spaceCount = rows - 1;
        int starCount = 1;

        for (int i = 0; i < rows; i++)
        {
            // Print spaces
            for (int j = 0; j < spaceCount; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 0; k < starCount; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            spaceCount--;
            starCount += 2;
        }

        spaceCount = 1;
        starCount = rows * 2 - 3;

        for (int i = 0; i < rows - 1; i++)
        {
            // Print spaces
            for (int j = 0; j < spaceCount; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 0; k < starCount; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            spaceCount++;
            starCount -= 2;
        }
    }
}
