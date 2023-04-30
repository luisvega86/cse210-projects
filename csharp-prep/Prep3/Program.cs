using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "y";
        while (response == "y")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int userGuess;
            int attempts = 0;

            Console.WriteLine("Guess the magic number!");
            do
            {
                attempts += 1;
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed in {attempts} attempts!");
                    Console.Write("Do you want to play again? (y/n): ");
                    response = Console.ReadLine();
                }
            }
            while (userGuess != number);
            Console.WriteLine("Thank you for playing!");
            
        }
    }
}