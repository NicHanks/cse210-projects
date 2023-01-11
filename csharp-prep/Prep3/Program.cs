using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int intMagicNumber = randomGenerator.Next(1, 101);

        //int guess = -1;

        // we could also use a to do-while loop here...
        //Console.WriteLine("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int intMagicNumber = int.Parse(magicNumber);
        int intGuess = -1;
        do
        {
            Console.WriteLine("What is your guess? ");
            intGuess = int.Parse(Console.ReadLine());
            if (intGuess == intMagicNumber)
            {
                Console.Write("Congradulations! You've guessed it!");
            }
            else if (intGuess < intMagicNumber)
            {
                Console.Write("Higher ");
            }
            else
            {
                Console.Write("Lower ");
            }
        } while (intGuess != intMagicNumber);
    }
}