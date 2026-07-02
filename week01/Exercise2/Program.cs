using System;

class Program
{
  static void Main(string[] args)
  {
    int gradeA = 90;
    int gradeB = 80;
    int gradeC = 70;
    int gradeD = 60;
    string letter;
    string sign;


    // Ask for their grade percentage
    Console.Write("What is your grade percent? ");
    string userInput = Console.ReadLine();

    int gradePercent = int.Parse(userInput);
    int lastDigit = gradePercent % 10;

    if (gradePercent >= gradeA)
    {
      letter = "A";
    }
    else if (gradePercent >= gradeB)
    {
      letter = "B";
    }
    else if (gradePercent >= gradeC)
    {
      letter = "C";
    }
    else if (gradePercent >= gradeD)
    {
      letter = "D";
    }
    else
    {
      letter = "F";
    }


    if (lastDigit >= 7)
    {
      sign = "+";
    }
    else if (lastDigit < 3)
    {
      sign = "-";
    }
    else
    {
      sign = "";
    }

    // Handle Special Case
    if (letter == "A" && sign == "+")
    {
      sign = "";
    }

    if (letter == "A" && gradePercent == 100)
    {
      sign = "";
    }
    
    if(letter == "F")
    {
      sign = "";
    }

    Console.WriteLine($"Your grade is {letter}{sign}");

    if (gradePercent >= gradeC)
    {
      Console.WriteLine("You passed this course");
    }
    else
    {
      Console.WriteLine("You can do better next time");
    }
  }
}