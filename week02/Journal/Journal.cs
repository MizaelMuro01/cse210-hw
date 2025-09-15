

public void LoadFromFile(string file)
{
    _entries.Clear();

    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");
        Entry loadedEntry = new Entry();
        loadedEntry._date = parts[0];
        loadedEntry._promptText = parts[1];
        loadedEntry._entryText = parts[2];

        _entries.Add(loadedEntry);
    }
    Console.WriteLine("Journal loaded from file.");
}