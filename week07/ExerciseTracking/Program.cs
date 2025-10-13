using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        List<Activity> activities = new List<Activity>();
        
        activities.Add(new Running(new DateTime(2024, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2024, 11, 3), 30, 12.0));
        activities.Add(new Swimming(new DateTime(2024, 11, 3), 30, 20));

        // Display summaries
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("-------------------------");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}