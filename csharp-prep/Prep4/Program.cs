using System;
// using System.Collections.Generic; ?
class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and append each one to a list.
        //Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int input = 1;
        while (input != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            input = int.Parse(response);
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        //float sum = numbers.Sum();
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = num + sum;
            // total += num
        }
        //double average = numbers.Average();
        float average = ((float)sum/numbers.Count);
        //float max = numbers.Max();
        int max = numbers[0];
        foreach (int i in numbers)
        {
            if (i > max)
            {
                max = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}