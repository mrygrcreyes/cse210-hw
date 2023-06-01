using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("May 22rd, 2023",  30, "Running", 2);
        activities.Add(run);

        Cycling cycling = new Cycling("May 24th, 2023", 60, "Cycling", 10);
        activities.Add(cycling);

        Swimming swimming = new Swimming("May 27th, 2023", 45, "Swimming", 20);
        activities.Add(swimming);
        
        Console.WriteLine("Welcome to the Exercise Tracking Program!");
        Console.WriteLine("Your activities for this week are:\n");

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}