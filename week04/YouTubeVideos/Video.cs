using System;

public class Video
{
  private string _videoTitle;
  private string _author;
  private int _length;
  private List<Comment> _comments = new List<Comment>();

  public Video(string title, string author, int length)
  {
    _videoTitle = title;
    _author = author;
    _length = length;
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }
  public int GetCommentCount()
  {
    return _comments.Count;
  }

  public void DisplayVideoInfo()
  {
    Console.WriteLine("===================================================");
    Console.WriteLine($"Video Title: {_videoTitle}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length} seconds");
    Console.WriteLine($"Total Comments: {GetCommentCount()}");

    Console.WriteLine();

    Console.WriteLine("COMMENTS:");
    foreach (Comment comment in _comments)
    {
      comment.DisplayComment();
    }
    Console.WriteLine();
  }
}