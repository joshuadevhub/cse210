// Creativity: This program exceeds the core requirements by allowing
// the user to record their mood along with each journal entry.
// The mood is displayed and saved to the file, and it is restored
// when the journal is loaded.

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

        Console.Write("How are you feeling today: ");
        string userMood = Console.ReadLine();

        string prompt = newPrompt.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write(">");
        string response = Console.ReadLine();

        DateTime today = DateTime.Now;
        newEntry._date = today.ToString("dd MMMM yyyy");
        newEntry._mood = userMood;
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        newJournal.AddEntry(newEntry);
        Console.WriteLine();

      }
      else if (userResponse == 2)
      {
        newJournal.DisplayAll();
      }else if (userResponse == 3)
      {
        Console.Write("Enter a filename to save your journal (without .txt): ");
        string fileName = Console.ReadLine();
        newJournal.SaveToFile(fileName);
      }else if (userResponse == 4)
      {
        Console.Write("Enter a filename to load your journal (without .txt): ");
        string fileName = Console.ReadLine();
        newJournal.LoadFromFile(fileName);
      }
      else if(userResponse == 5)
      {
        Console.WriteLine("Thanks for entering our page!");
        break;
      }
      else
      {
        Console.WriteLine("Invalid Choice! Please chose again.");
        Console.WriteLine();
      }
    }

  }
}