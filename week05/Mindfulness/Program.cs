using System;

class Program
{
    static void Main(string[] args)
    {
bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().RunActivity();
                    break;
                case "2":
                    new ReflectionActivity().RunActivity();
                    break;
                case "3":
                    new ListingActivity().RunActivity();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }    
}