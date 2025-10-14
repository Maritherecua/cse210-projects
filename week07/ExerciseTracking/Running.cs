// this class claculates the distance, speed, pace (minutes per mile) for running
//provides a summary in the form of: date, running (minutes), distance (miles), speed, Pace (min/mile)
using System;

public class Running : Activity
{
    private double distance;

    public Running(string date, double duration, double distance) : base(date, duration)
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
        return $"{date} - Running ( {duration} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min/mile";
    }
}