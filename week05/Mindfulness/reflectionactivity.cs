using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect";
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Show random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("When you have something in mind, press enter to continue ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        // random question
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.Write($"\n{question} ");
            ShowSpinner(10);
        }

        DisplayEndingMessage();
    }
}