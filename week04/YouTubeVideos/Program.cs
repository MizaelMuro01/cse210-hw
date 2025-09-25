using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // V1
        Video video1 = new Video();
        video1._title = "C# Tutorial";
        video1._author = "John Doe";
        video1._length = 600;
        
        Comment comment1 = new Comment();
        comment1._name = "Alice";
        comment1._text = "Great tutorial!";
        video1._comments.Add(comment1);
        
        Comment comment2 = new Comment();
        comment2._name = "Bob";
        comment2._text = "Very helpful";
        video1._comments.Add(comment2);
        
        videos.Add(video1);

        // V2
        Video video2 = new Video();
        video2._title = "Learning Programming";
        video2._author = "Jane Smith";
        video2._length = 300;
        
        Comment comment3 = new Comment();
        comment3._name = "Charlie";
        comment3._text = "I learned a lot";
        video2._comments.Add(comment3);
        
        videos.Add(video2);

        // V3
        Video video3 = new Video();
        video3._title = "Book of Mormon Study";
        video3._author = "Elder Johnson";
        video3._length = 900;
        
        Comment comment4 = new Comment();
        comment4._name = "Sarah";
        comment4._text = "Inspiring message";
        video3._comments.Add(comment4);
        
        Comment comment5 = new Comment();
        comment5._name = "Michael";
        comment5._text = "Thank you for this";
        video3._comments.Add(comment5);
        
        videos.Add(video3);

        //all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}