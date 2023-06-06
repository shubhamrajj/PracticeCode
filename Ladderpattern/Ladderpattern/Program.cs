using System;

class Program
{
    static void Main()
    {
        int steps = 5;
        PrintLadderPattern(steps);
    }

    static void PrintLadderPattern(int steps)
    {
        for (int i = 1; i <= steps; i++)
        {
            // Print left side of the ladder
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            // Print space between the sides
            for (int k = i + 1; k <= steps; k++)
            {
                Console.Write(" ");
            }

            // Print right side of the ladder
            for (int l = i + 1; l <= steps; l++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
