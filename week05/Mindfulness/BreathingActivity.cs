using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")
    { }

    public void RunActivity()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);
            Console.WriteLine("Breathe out...");
            Countdown(4);
        }
        EndActivity();
    }
}