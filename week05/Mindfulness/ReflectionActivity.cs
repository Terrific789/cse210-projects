class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times you've shown strength and resilience.") {}

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Length)]}");
        SpinnerAnimation(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine($"> {question}");
            SpinnerAnimation(5);
        }
    }
}