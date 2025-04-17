using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();
}