using System;

class Program
{
    static void Main()
    {
        int rows = 5;

        PrintNumberPyramid(rows);
    }

    static void PrintNumberPyramid(int rows)
    {
        int number = 1;
        int spaces = rows - 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= spaces; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine();
            spaces--;
        }
    }
}
