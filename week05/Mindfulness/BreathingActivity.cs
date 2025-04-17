class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing.") {}

    protected override void PerformActivity()
    {
        int totalTime = GetDuration();
        int cycleTime = 6; // 3 seconds in, 3 seconds out
        int cycles = totalTime / cycleTime;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in... ");
            Countdown(3);
            Console.Write("\nBreathe out... ");
            Countdown(3);
        }
    }
}
