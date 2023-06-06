using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 7, 45, 23, 56, 12, 98, 34 };
        int[] greatestPair = FindGreatestPair(array);

        Console.WriteLine("The greatest pair is: {0} and {1}", greatestPair[0], greatestPair[1]);
    }

    static int[] FindGreatestPair(int[] array)
    {
        if (array.Length < 2)
        {
            throw new ArgumentException("Array must contain at least 2 elements");
        }

        int[] greatestPair = { array[0], array[1] };

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] > greatestPair[0])
            {
                greatestPair[1] = greatestPair[0];
                greatestPair[0] = array[i];
            }
            else if (array[i] > greatestPair[1])
            {
                greatestPair[1] = array[i];
            }
        }

        return greatestPair;
    }
}
