using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = DateTime.Now, Duration = 30, Distance = 3.0 },
            new Cycling { Date = DateTime.Now, Duration = 45, Speed = 15.0 },
            new Swimming { Date = DateTime.Now, Duration = 40, Laps = 30 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}