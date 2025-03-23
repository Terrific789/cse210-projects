using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // List of predefined prompts
    private static readonly List<string> prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "Who made you smile today?",
        "What is one thing you are grateful for?",
        "Describe a challenge you faced today."
    };

    // Get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }

    // Add a new entry
    public void AddEntry(string response)
    {
        string prompt = GetRandomPrompt();
        entries.Add(new Entry(prompt, response));
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries found.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"[{entry.Date}] {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    // Save journal to file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.FormatForSaving());
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load journal from file
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1].Trim(), parts[2].Trim()) { Date = parts[0].Trim() };
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
