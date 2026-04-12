using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nScore: {_score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") Save();
            else if (choice == "5") Load();
            else if (choice == "6") break;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));
        else
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void Save()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
                sw.WriteLine(g.GetStringRepresentation());
        }
    }

    private void Load()
    {
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] data = parts[1].Split(",");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5])));
        }
    }
}