using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int userChoice = 0;

        Console.WriteLine("Jornaul program");

        while (userChoice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1- Write a new entry");
            Console.WriteLine("2- Display the journal");
            Console.WriteLine("3- Save the journal to a file");
            Console.WriteLine("4- Load the journal from a file");
            Console.WriteLine("5- Quit");
            Console.Write("What would you like to do?");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string randomPrompt = promptGen.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("Your response:");
                string userResponse = Console.ReadLine();
                
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = userResponse;

                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry saved");
            }
            else if (userChoice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter the filename to save:");
                string saveFile = Console.ReadLine();
                myJournal.SaveToFile(saveFile);
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter the filename to load:");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Don´t let me alone bro");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1-5.");
            }
        }
    }
}