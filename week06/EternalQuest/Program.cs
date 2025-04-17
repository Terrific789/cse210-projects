using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest - Choose an option:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": Console.WriteLine($"Current score: {score}"); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
                case "7": running = false; break;
                default: Console.WriteLine("Invalid option"); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1": goals.Add(new SimpleGoal(name, desc, points)); break;
            case "2": goals.Add(new EternalGoal(name, desc, points)); break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default: Console.WriteLine("Invalid type"); break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} - {goals[i].Description}");
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter goal number to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"Event recorded! You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(score);
            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(',');

                switch (type)
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
                        break;
                }
            }
            Console.WriteLine("Goals loaded!");
        }
        else
        {
            Console.WriteLine("No saved goals file found.");
        }
    }
}