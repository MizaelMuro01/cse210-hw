using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video();
        v1.title = "C# Tutorial";
        v1.author = "John Doe";
        v1.length = 600;
        
        Comment c1 = new Comment();
        c1.name = "Alice";
        c1.text = "Great tutorial!";
        v1.comments.Add(c1);
        
        Comment c2 = new Comment();
        c2.name = "Bob";
        c2.text = "Very helpful";
        v1.comments.Add(c2);
        
        videos.Add(v1);

        // Video 2
        Video v2 = new Video();
        v2.title = "Learning Programming";
        v2.author = "Jane Smith";
        v2.length = 300;
        
        Comment c3 = new Comment();
        c3.name = "Charlie";
        c3.text = "I learned a lot";
        v2.comments.Add(c3);
        
        videos.Add(v2);

        // Video 3
        Video v3 = new Video();
        v3.title = "Book of Mormon Study";
        v3.author = "Elder Johnson";
        v3.length = 900;
        
        Comment c4 = new Comment();
        c4.name = "Sarah";
        c4.text = "Inspiring message";
        v3.comments.Add(c4);
        
        Comment c5 = new Comment();
        c5.name = "Michael";
        c5.text = "Thank you for this";
        v3.comments.Add(c5);
        
        videos.Add(v3);

        // Show all videos
        foreach (Video v in videos)
        {
            v.ShowVideo();
        }
    }
}