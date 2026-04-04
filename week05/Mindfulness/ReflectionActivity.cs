using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you helped someone.",
        "Think of a time when you overcame a challenge.",
        "Think of a time when you did something selfless.",
        "Think of a time when you showed courage."
    };

    private string[] _questions = {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How can you apply this in the future?",
        "How did you feel during this experience?",
        "What made this time different from others?"
    };

    private Random _rand = new Random();

    public ReflectionActivity()
        : base("Reflection Activity", "This activity helps you reflect on times when you showed strength or resilience.")
    { }

    public void RunActivity()
    {
        StartActivity();
        Console.WriteLine("\nPrompt: " + _prompts[_rand.Next(_prompts.Length)]);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[_rand.Next(_questions.Length)];
            Console.WriteLine("\n" + question);
            DisplayAnimation(4);
        }
        EndActivity();
    }
}