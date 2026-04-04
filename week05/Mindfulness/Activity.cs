using System;
using System.Threading;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration; // duration in seconds

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter duration of activity in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_activityName} ---");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Get ready...");
        DisplayAnimation(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {_activityName} for {_duration} seconds.");
        DisplayAnimation(3);
    }

    protected void DisplayAnimation(int seconds)
    {
        string spinner = "|/-\\";
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}