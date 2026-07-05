using System;

class Program
{
  static void Main(string[] args)
  {
    DisplayWelcome();
    string username = PromptUserName();
    int favoriteNumber = PromptUserNumber();
    int squareNumber = SquareNumber(favoriteNumber);
    DisplayResult(username, squareNumber);
  }

  static void DisplayWelcome()
  {
    Console.WriteLine("Welcome to the Program!");
  }

  static string PromptUserName()
  {
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    return userName;
  }

  static int PromptUserNumber()
  {
    Console.Write("Please enter your favorite number: ");
    int favoriteNumber = int.Parse(Console.ReadLine());
    return favoriteNumber;
  }

  static int SquareNumber(int num)
  {
    return num * num;
  }
  
  static void DisplayResult(string username, int squareNumbered)
  {
    Console.WriteLine($"Hello {username}, the square of your number is {squareNumbered}");
  }
}