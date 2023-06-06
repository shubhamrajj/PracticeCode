using System;

class Program
{
    static void Main()
    {
        int rows = 5; // Number of rows in the triangle

        // Loop for each row
        for (int i = 1; i <= rows; i++)
        {
            // Loop to print the numbers in each row
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine(); // Move to the next line after each row
        }
    }
}
