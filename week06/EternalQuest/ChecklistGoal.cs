class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int Bonus { get; set; }
    public int CompletedCount { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int completedCount = 0)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        CompletedCount = completedCount;
    }

    public override bool IsComplete() => CompletedCount >= TargetCount;

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            CompletedCount++;
            return CompletedCount == TargetCount ? Points + Bonus : Points;
        }
        return 0;
    }

    public override string GetStatus() => IsComplete() ? "[X]" : $"[{CompletedCount}/{TargetCount}]";

    public override string GetStringRepresentation() => $"ChecklistGoal:{Name},{Description},{Points},{Bonus},{TargetCount},{CompletedCount}";
}
