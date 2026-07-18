using System;
using System.Collections.Generic;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, string scriptureText)
  {
    _words = new List<Word>();
    _reference = reference;
    string[] splitText = scriptureText.Split(' ');
    foreach(string wordText  in splitText)
    {
      Word word = new Word(wordText );
      _words.Add(word);
    }
  }

  public string GetDisplayText()
  {
    string result = "";
    string referenceText = _reference.GetDisplayText();
    result += $"{referenceText}\n";

    foreach(Word word in _words)
    {
      string eachWord = word.GetDisplayText();
      result += $"{eachWord} ";
    }
    return result;
  }
  public void HideRandomWords(int numberToHide)
  {
    Random random = new Random();
    int numberOfHiddenWord = 0;

    while (numberOfHiddenWord != numberToHide)
    {
      int index = random.Next(0, _words.Count);
      Word indexWord = _words[index];

      if (indexWord.IsHidden())
      {

      }
      else
      {
        indexWord.Hide();
        numberOfHiddenWord += 1;
      }
    }
  }
  
  public bool IsCompletelyHidden()
  {
    foreach (Word word in _words)
    {
      bool hiddenWord = word.IsHidden();
      if (!hiddenWord)
      {
        return false;
      }
    }
    return true;
  }
}