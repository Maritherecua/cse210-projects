// this class calculates the distance, speed, pace (minutes per mile), number of laps for swimming (lap pool).
using System;

public class Swimming : Activity
{
    private double laps;

    public Swimming(string date, double duration, double laps) : base(date, duration)
    {
        this.laps = laps;
    }
    public int GetLaps()
    {
        return (int)laps;
    }
    public override double GetDistance()
    {
        return laps * 0.025; // convert laps to miles (1 lap = 50m, 1 mile = 1609.34m)
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
        return $"{date} - Swimming ({duration} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min/mile, Laps {GetLaps()} laps";
    }
}


    //public Swimming(string date, double duration, double distance) : base(date, duration)
    //{
        //this.distance = distance;
    /// <summary>
    /// /}
    /// </summary>
    /// <returns></returns>

    //public override double GetDistance()
    //{
        //return distance;
    //}

    //public override double GetSpeed()
    //{
        //return GetDistance() / duration * 60;
    //}

    //public override double GetPace()
    //{
        //return duration / GetDistance();
    ////}

    //public override string GetSummary()
    //{
        //return $"{date} - Swimming ({duration} min): {GetDistance()} miles, {GetSpeed()} mph, {GetPace()} min/mile";
    //}
//}
