using System;

public class Comment
{
  private string _commenterName;
  private string _commentText;
  public Comment(string commenterName, string commenterText)
  {
    _commenterName = commenterName;
    _commentText = commenterText;
  }

  public void DisplayComment()
  {
    Console.WriteLine(_commenterName);
    Console.WriteLine($"\t{_commentText}");
  }
}