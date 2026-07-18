/*
 * EXTRA FEATURE IMPLEMENTED
 * -------------------------
 * As an enhancement to the original assignment, I added a scripture selection
 * menu at the beginning of the program. Instead of using only one hard-coded
 * scripture, the user can choose from three different scriptures before the
 * memorization activity begins.
 *
 * This improvement demonstrates:
 * - User input validation using a do-while loop.
 * - Conditional logic (if/else if) to create different Reference and Scripture objects.
 * - A more interactive and user-friendly experience.
 *
 * The rest of the program continues to use the same Word, Reference, and
 * Scripture classes without modification, demonstrating the benefits of
 * object-oriented design and encapsulation.
 */

using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("==================================");
    Console.WriteLine("     Scripture Memorizer");
    Console.WriteLine("==================================");

    Console.WriteLine();

    Reference reference;
    Scripture scripture;
    int choice;

    do
    {
      Console.WriteLine("Choose a scripture:");
      Console.WriteLine("1. John 3:16");
      Console.WriteLine("2. Proverbs 3:5-6");
      Console.WriteLine("3. 2 Nephi 3:5");

      Console.Write("> ");

      choice = int.Parse(Console.ReadLine());
      if (choice < 1 || choice > 3)
      {
        Console.WriteLine("Invalid choice. Please try again.");
        Console.WriteLine();
      }
    } while (choice < 1 || choice > 3);

    if (choice == 1)
    {
      reference = new Reference("John", 3, 16);
      scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life");
    }
    else if (choice == 2)
    {
      reference = new Reference("Proverbs", 3, 5, 6);
      scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding; in all your ways acknowledge him, and he shall direct thy paths");
    }
    else
    {
      reference = new Reference("2 Nephi", 3, 5);
      scripture = new Scripture(reference, "Wherefore, Joseph truly saw our day. And he obtained a promise of the Lord, that out of the fruit of loin the Lord God would raise up righteous branch unto the house of Israel; not the Messiah, but a branch which was to be broken off, nevertheless, to be remembered in the covenants of the Lord Messiah should be made manifest unto them in the latter days, in the spirit of power, unto the bringing of them out of darkness unto light, yea, out of hidden darkness and out of captivity unto freedom.");
    }
    
    Console.Clear();

    while (!scripture.IsCompletelyHidden())
    {
      string displayedText = scripture.GetDisplayText();
      Console.WriteLine(displayedText);

      Console.WriteLine();

      Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
      string userInput = Console.ReadLine();

      if (userInput == "quit")
      {
        break;
      }
      scripture.HideRandomWords(3);
    }

    Console.Clear();

    string displayScripture = scripture.GetDisplayText();
    Console.WriteLine(displayScripture);

    Console.WriteLine();

    Console.WriteLine("Thanks for using the Scripture Memorizer!");
  }
}