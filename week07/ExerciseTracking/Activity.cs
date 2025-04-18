using System;

public abstract class Activity
{
    protected DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance();  // To be implemented in derived classes
    public abstract double GetSpeed();     // To be implemented in derived classes
    public abstract double GetPace();      // To be implemented in derived classes

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
