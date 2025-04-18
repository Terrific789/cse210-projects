using System;

public class Running : Activity
{
    private double distance;  // Distance in kilometers

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;  // Returns distance for running
    }

    public override double GetSpeed()
    {
        return (distance / minutes) * 60;  // Speed in km/h
    }

    public override double GetPace()
    {
        return minutes / distance;  // Pace in minutes per km
    }
}
