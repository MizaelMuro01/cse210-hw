using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("2 Nephi 4:15", "And upon these I write the things of my soul");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit:");
            
            string input = Console.ReadLine();
            
            if (input == "quit") break;
            if (scripture.IsCompletelyHidden()) break;
            
            scripture.HideRandomWords();
        }
        
        Console.WriteLine("Good job!");
    }
}

class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsHidden = 0;
        
        while (wordsHidden < 2)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden)
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string result = _reference + " ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden) return false;
        }
        return true;
    }
}

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}