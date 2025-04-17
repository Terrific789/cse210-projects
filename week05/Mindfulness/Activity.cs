abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        SpinnerAnimation(3);
        PerformActivity();
        End();
    }

    protected abstract void PerformActivity();

    protected int GetDuration()
    {
        return _duration;
    }

    protected void End()
    {
        Console.WriteLine("\nWell done!");
        SpinnerAnimation(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        SpinnerAnimation(3);
    }

    protected void SpinnerAnimation(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}