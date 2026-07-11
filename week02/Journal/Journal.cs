using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    foreach(Entry entry in _entries)
    {
      entry.Display();
    }
  }

  public void SaveToFile(string file)
  {
    StreamWriter writer = new StreamWriter($"{file}.txt");
    foreach (Entry entry in _entries)
    {
      writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
    }
    writer.Close();
  }

  public void LoadFromFile(string file)
  {
    if (File.Exists($"{file}.txt"))
    {
      _entries.Clear();
      StreamReader reader = new StreamReader($"{file}.txt");
      string line = reader.ReadLine();

      while (line != null)
      {
        string[] parts = line.Split('|');

        Entry newEntry = new Entry();
        newEntry._date = parts[0];
        newEntry._promptText = parts[1];
        newEntry._entryText = parts[2];
        AddEntry(newEntry);

        line = reader.ReadLine();
      }
      reader.Close();
    }
    else
    {
      Console.WriteLine("File not found!");
      Console.WriteLine();
    }
  }
}