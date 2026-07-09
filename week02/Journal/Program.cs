using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    Journal newJournal = new Journal();
    PromptGenerator newPrompt = new PromptGenerator();

    Console.WriteLine();

    List<string> menu = new List<string>();
    menu.Add("Write");
    menu.Add("Display");
    menu.Add("Save");
    menu.Add("Load");
    menu.Add("Quit");

    while (true)
    {
      for (int i = 0; i < menu.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {menu[i]}");
      }

      Console.Write("Chose a number from the options above to start your journal entry: ");
      int userResponse = int.Parse(Console.ReadLine());

      Console.WriteLine();
      if (userResponse == 1)
      {
        Entry newEntry = new Entry();
        string prompt = newPrompt.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write(">");
        string response = Console.ReadLine();

        // Hardcoded Date for testing for now;
        newEntry._date = "July 09 2026";
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        newJournal.AddEntry(newEntry);

      }
      else if (userResponse == 2)
      {
        newJournal.DisplayAll();
      }else if(userResponse == 5)
      {
        Console.WriteLine("Thanks for entering our page!");
        break;
      }
      else
      {
        Console.WriteLine("Invalid Choice! Please chose again.");
        Console.WriteLine();
        // continue;
      }
    }

  }
}