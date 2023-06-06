using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 2, 5, 1, 3 };

        bool result = CheckSameElements(array1, array2);

        if (result)
        {
            Console.WriteLine("The arrays contain the same elements.");
        }
        else
        {
            Console.WriteLine("The arrays do not contain the same elements.");
        }
    }

    static bool CheckSameElements(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        int[] sortedArray1 = array1.OrderBy(x => x).ToArray();
        int[] sortedArray2 = array2.OrderBy(x => x).ToArray();

        for (int i = 0; i < sortedArray1.Length; i++)
        {
            if (sortedArray1[i] != sortedArray2[i])
            {
                return false;
            }
        }

        return true;
    }
}
