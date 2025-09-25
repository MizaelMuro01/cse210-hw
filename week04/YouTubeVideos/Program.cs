using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1._title = "C# Tutorial";
        video1._author = "John Doe";
        video1._length = 600;
        
        video1._comments.Add(new Comment { _name = "Alice", _text = "Great tutorial!" });
        video1._comments.Add(new Comment { _name = "Bob", _text = "Very helpful" });
        videos.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2._title = "Learning Programming";
        video2._author = "Jane Smith";
        video2._length = 300;
        
        video2._comments.Add(new Comment { _name = "Charlie", _text = "I learned a lot" });
        videos.Add(video2);

        // Show all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}