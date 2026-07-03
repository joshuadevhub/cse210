using System;

class Program
{
    static void Main(string[] args)
  {
    int numberOfGuess = 1;
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);

    Console.WriteLine("Guess a number between 1 and 100");

    Console.WriteLine();

    Console.Write("What is the magic number: ");
    string userInput = Console.ReadLine();
    int userGuess = int.Parse(userInput);

    while (userGuess != magicNumber)
    {
      if (userGuess < magicNumber)
      {
        Console.WriteLine("Higher");
      }
      else if (userGuess > magicNumber)
      {
        Console.WriteLine("Lower");
      }

      numberOfGuess++;
      Console.Write("Try again. Enter a number: ");
      userGuess = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();

    Console.WriteLine("Congratulations! You guessed the magic number.");
    Console.WriteLine($"You guessed it in {numberOfGuess} attempts");
    }
}