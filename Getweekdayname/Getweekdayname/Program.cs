using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Generate a random number between 1 and 7
        Random random = new Random();
        int randomNumber = random.Next(1, 8);

        string weekday = GetWeekdayName(randomNumber);

        Console.WriteLine("Randomly generated number: " + randomNumber);
        Console.WriteLine("Weekday: " + weekday);
    }

    static string GetWeekdayName(int number)
    {
        switch (number)
        {
            case 1:
                return "Sunday";
            case 2:
                return "Monday";
            case 3:
                return "Tuesday";
            case 4:
                return "Wednesday";
            case 5:
                return "Thursday";
            case 6:
                return "Friday";
            case 7:
                return "Saturday";
            default:
                return "Invalid number";
        }
    }
}
