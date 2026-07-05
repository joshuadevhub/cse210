using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    List<int> userLists = new List<int>();

    double sum = 0;

    Console.Write("Enter a number (or 0 to finish): ");
    int userResponse = int.Parse(Console.ReadLine());
    while (userResponse != 0)
    {
      userLists.Add(userResponse);
      Console.Write("Enter a number (or 0 to finish): ");
      userResponse = int.Parse(Console.ReadLine());
    }
    int maximumNumber = userLists[0];

    foreach (int number in userLists)
    {
      sum += number;
      if (number > maximumNumber)
      {
        maximumNumber = number;
      }
    }

    Console.WriteLine($"The sum is: {sum}");

    double average = sum / userLists.Count;
    Console.WriteLine($"The average is: {average}");

    Console.WriteLine($"The maximum number is: {maximumNumber}");

    userLists.Sort();

    foreach(int smallestPositiveNum in userLists)
    {
      if(smallestPositiveNum > 0)
      {
        Console.WriteLine($"The smallest positive number is {smallestPositiveNum}");
        break;
      }
    }
    Console.WriteLine("The sorted list is:");
    foreach(int sortedNumber in userLists)
    {
      Console.WriteLine(sortedNumber);
    }
  }
}