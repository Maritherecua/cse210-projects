// this is the base class. Contains any attributes shared by the three activities
//declares but not implement methods for getting the distance, speed, and pace ( which will be overriden in the subclasses)
using System;

public abstract class Activity
{
    protected string date;
    protected double duration;

    public Activity(string date, double duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{date} - Duration: {duration} minutes";
    }
}
// The Main method is in Program.cs