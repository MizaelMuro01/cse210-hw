public class Comment
{
    public string name;
    public string text;

    public void ShowComment()
    {
        Console.WriteLine("- " + name + ": " + text);
    }
}