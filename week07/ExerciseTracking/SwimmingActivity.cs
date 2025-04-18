using System;

public class Swimming : Activity
{
    private int laps;  // Number of laps

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;  // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / minutes) * 60;  // Speed in km/h
    }

    public override double GetPace()
    {
        return minutes / GetDistance();  // Pace in minutes per km
    }
}
