using System.Collections.Generic;

public class Video
{
    public string title;
    public string author;
    public int length;
    public List<Comment> comments = new List<Comment>();

    public int CountComments()
    {
        return comments.Count;
    }

    public void ShowVideo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + length + " seconds");
        Console.WriteLine("Comments: " + CountComments());
        
        foreach (Comment c in comments)
        {
            c.ShowComment();
        }
        Console.WriteLine();
    }
}