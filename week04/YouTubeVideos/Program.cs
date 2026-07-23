using System;

class Program
{
  static void Main(string[] args)
  {

    List<Video> videos = new List<Video>();

    // Video 1
    Video video1 = new Video("God of War Ragnarök Gameplay Review", "GameVerse", 840);
    Comment video1Comment1 = new Comment("David", "This gameplay is incredible!");
    Comment video1Comment2 = new Comment("Sarah", "I can't wait to play this game.");
    Comment video1Comment3 = new Comment("Michael", "The graphics look amazing.");

    // Video 2
    Video video2 = new Video("Spider-Man Movie Trailer Breakdown", "Cinema Hub", 620);
    Comment video2Comment1 = new Comment("Grace", "The trailer gave me chills!");
    Comment video2Comment2 = new Comment("Daniel", "I hope this movie lives up to the hype.");
    Comment video2Comment3 = new Comment("Sophia", "The action scenes look awesome.");

    // Video 3
    Video video3 = new Video("The Eternals Explained", "Marvel Central", 480);
    Comment video3Comment1 = new Comment("James", "This explanation really helped.");
    Comment video3Comment2 = new Comment("Olivia", "I finally understand the storyline.");
    Comment video3Comment3 = new Comment("Ethan", "Thanks for making this video.");

    // Video 4
    Video video4 = new Video("Train Journey from Lagos to Abuja", "Travel Diaries", 960);
    Comment video4Comment1 = new Comment("Emma", "The scenery is beautiful.");
    Comment video4Comment2 = new Comment("Noah", "I enjoyed watching the entire trip.");
    Comment video4Comment3 = new Comment("Ava", "Very informative travel vlog.");

    video1.AddComment(video1Comment1);
    video1.AddComment(video1Comment2);
    video1.AddComment(video1Comment3);

    video2.AddComment(video2Comment1);
    video2.AddComment(video2Comment2);
    video2.AddComment(video2Comment3);

    video3.AddComment(video3Comment1);
    video3.AddComment(video3Comment2);
    video3.AddComment(video3Comment3);

    video4.AddComment(video4Comment1);
    video4.AddComment(video4Comment2);
    video4.AddComment(video4Comment3);

    videos.Add(video1);
    videos.Add(video2);
    videos.Add(video3);
    videos.Add(video4);
    
    foreach (Video video in videos)
    {
        video.DisplayVideoInfo();
        Console.WriteLine("----------------------------------------");
    }
  }
}