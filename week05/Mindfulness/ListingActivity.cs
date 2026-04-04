using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "Who are your personal heroes?"
    };

    private Random _rand = new Random();

    public ListingActivity()
        : base("Listing Activity", "This activity helps you list as many positive things in your life as possible.")
    { }

    public void RunActivity()
    {
        StartActivity();
        string prompt = _prompts[_rand.Next(_prompts.Length)];
        Console.WriteLine("\nPrompt: " + prompt);
        Console.WriteLine("Start listing your items. Press Enter after each one:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndActivity();
    }
}