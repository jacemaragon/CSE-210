public abstract class Activity
{
    public DateTime Date { get; set; }
    public double Duration { get; set; } 

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({Duration} min) - Distance {GetDistance()} units, Speed {GetSpeed()} units/hr, Pace: {GetPace()} min per unit";
    }
}