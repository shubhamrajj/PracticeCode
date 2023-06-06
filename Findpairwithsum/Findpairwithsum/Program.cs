using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array = { 2, 4, 6, 8, 10 };
        int targetSum = 12;

        List<int[]> pairs = FindPairsWithSum(array, targetSum);

        Console.WriteLine("Pairs with sum {0}:", targetSum);
        foreach (int[] pair in pairs)
        {
            Console.WriteLine("({0}, {1})", pair[0], pair[1]);
        }
    }

    static List<int[]> FindPairsWithSum(int[] array, int targetSum)
    {
        List<int[]> pairs = new List<int[]>();

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == targetSum)
                {
                    int[] pair = { array[i], array[j] };
                    pairs.Add(pair);
                }
            }
        }

        return pairs;
    }
}
