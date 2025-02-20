using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option. Press Enter to return.");
                Console.ReadLine();
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("\nGoal created successfully! Press Enter to return.");
        Console.ReadLine();
    }

private void ListGoals()
{
    Console.Clear();
    Console.WriteLine($"You are currently at Level {GetLevel()} ({GetRankTitle()})");
    Console.WriteLine("The goals are:");
    
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    Console.WriteLine($"\nYou have {_score} points.");
    Console.WriteLine("Press Enter to return to the menu.");
    Console.ReadLine();
}


    private void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += int.Parse(_goals[index].GetPoints());
            Console.WriteLine("\nEvent recorded! Press Enter to return.");
        }
        else
        {
            Console.WriteLine("Invalid selection. Press Enter to return.");
        }
        Console.ReadLine();
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("\nGoals saved successfully! Press Enter to return.");
        Console.ReadLine();
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("\nNo saved goals found. Press Enter to return.");
            Console.ReadLine();
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            Goal loadedGoal = null;
            if (type == "SimpleGoal")
            {
                loadedGoal = new SimpleGoal(data[0], data[1], data[2]);
            }
            else if (type == "EternalGoal")
            {
                loadedGoal = new EternalGoal(data[0], data[1], data[2]);
            }
            else if (type == "ChecklistGoal")
            {
                loadedGoal = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]));
            }

            if (loadedGoal != null)
            {
                _goals.Add(loadedGoal);
            }
        }
        Console.WriteLine("\nGoals loaded successfully! Press Enter to return.");
        Console.ReadLine();
    }
    // Determines player's level based on score
    private int GetLevel()
    {
        return _score / 500 + 1;  // Every 500 points = Level Up
    }

    // Determines player's rank title based on level
    private string GetRankTitle()
    {
        int level = GetLevel();
        if (level >= 10) return "Master Achiever";
        if (level >= 7) return "Elite Explorer";
        if (level >= 5) return "Advanced Goal-Getter";
        if (level >= 3) return "Dedicated Challenger";
        return "Beginner";
    }
}







