using System;
using System.Collections.Generic;

public class PromptGenerator
{
  public List<string> _prompts = new List<string>();
  
  public string GetRandomPrompt()
  {
    if (_prompts.Count == 0)
    {
      _prompts.Add("Who was the most interesting person I interacted with today?");
      _prompts.Add("What was the best part of my day?");
      _prompts.Add("How did I see the hand of the Lord in my life today?");
      _prompts.Add("What was the strongest emotion I felt today?");
      _prompts.Add("If I had one thing I could do over today, what would it be?");
      _prompts.Add("What made me smile today?");
      _prompts.Add("What challenge did I overcome today?");
      _prompts.Add("What lesson did I learn today?");
      _prompts.Add("What is one thing I am grateful for today?");
      _prompts.Add("Who encouraged me today, and how?");
      _prompts.Add("What is something new I discovered today?");
      _prompts.Add("What was my biggest accomplishment today?");
      _prompts.Add("How did I help someone today?");
      _prompts.Add("What would I like to improve tomorrow?");
      _prompts.Add("What is one goal I want to accomplish this week?");
      _prompts.Add("What made today different from yesterday?");
      _prompts.Add("What was the funniest thing that happened today?");
      _prompts.Add("What did I spend most of my time doing today?");
      _prompts.Add("What scripture, quote, or thought inspired me today?");
      _prompts.Add("What am I looking forward to tomorrow?");
      _prompts.Add("What decision did I make today that I'm proud of?");
      _prompts.Add("What distracted me the most today?");
      _prompts.Add("How did I take care of my health today?");
      _prompts.Add("What is one memory from today I never want to forget?");
      _prompts.Add("If I could relive one moment from today, what would it be?");
    }

    // Get a random prompt
    Random random = new Random();
    int index = random.Next(0, _prompts.Count);
    string prompt = _prompts[index];

    return prompt;
  }
  
}