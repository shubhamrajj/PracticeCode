// C# program to remove the first
// and last character of each word in a string.
using System;

class FAL
{
    static String FirstAndLast(String str)
    {

        // Create an equivalent char array
        // of given string
        char[] ch = str.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {

            // k stores index of first character
            // and i is going to store index of last
            // character.
            int k = i;
            while (i < ch.Length && ch[i] != ' ')
                i++;

            // Check if the character is a small letter
            // If yes, then Capitalise
            ch[k] = (char)(ch[k] >= 'a' && ch[k] <= 'z'
                            ? ((int)ch[k] - 32)
                            : (int)ch[k]);
            ch[i - 1] = (char)(ch[i - 1] >= 'a' && ch[i - 1] <= 'z'
                                ? ((int)ch[i - 1] - 32)
                                : (int)ch[i - 1]);
        }

        return new String(ch);
    }

    // Driver code
    public static void Main(String[] args)
    {
        String str = "shubham raj";
        Console.WriteLine(str);
        Console.WriteLine(FirstAndLast(str));
    }
}
