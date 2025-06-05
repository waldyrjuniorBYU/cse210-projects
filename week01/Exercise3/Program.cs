using System;

class Program
{
    static void Main(string[] args)
    {
        int guessNumber;
        Random randomGenerator = new Random();

        int pickNumber = randomGenerator.Next(1, 101);
        /* Console.WriteLine($"Number {pickNumber}."); */

        do
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < pickNumber)
            {
                Console.Write("Higher \n");
            }
            else if (guessNumber > pickNumber)
            {
                Console.Write("Lower \n");
            }
            else
            {
                Console.Write("You guessed it! \n");
            }
        }
        while (pickNumber != guessNumber);
    }
}