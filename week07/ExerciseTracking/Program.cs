//this program puts each activity in the same list then iterates through the list and call the GetSummary on each item to display each activity's summary.
//uses inheritance to avoid duplicaring shared attributes and methods
//uses polymorphism to call the appropriate GetSummary method for each activity type
//follows the principles of encapsulation by keeping the attributes private and providing public methods to access them


using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("2025-Oct-01", 30, 3.0));
        activities.Add(new Cycling("2025-Oct-02", 45, 15.0));
        activities.Add(new Swimming("2025-Oct-03", 60, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}