using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        PrintHollowPyramid(rows);
    }

    static void PrintHollowPyramid(int rows)
    {
        int spaceCount = rows - 1;
        int starCount = 1;

        // Print upper part of the pyramid
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
                // Print asterisks only at the edges or if it's the last row
                if (k == 0 || k == starCount - 1 || i == rows - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

            spaceCount--;
            starCount += 2;
        }
    }
}
