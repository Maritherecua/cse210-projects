// this class calculates the distance, speed(miles per hour), pace (minutes per mile) for cycling
using System;

public class Cycling : Activity
{
    private double distance;

    public Cycling(string date, double duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / duration * 60;
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{date} - Cycling ({duration} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min/mile";
    }
}
