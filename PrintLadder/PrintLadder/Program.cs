using System;

class Program
{
    static void Main()
    {
        int steps = 5;
        PrintLadder(steps);
    }

    static void PrintLadder(int steps)
    {
        for (int i = 1; i <= steps; i++)
        {
            // Print left side of the ladder
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            // Print right side of the ladder
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
