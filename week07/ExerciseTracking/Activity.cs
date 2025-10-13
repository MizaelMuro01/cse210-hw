using System;

public class Activity
{
    private DateTime _date;
    private int _length; // in minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0; // Will be overridden
    }

    public virtual double GetSpeed()
    {
        return 0; // Will be overridden
    }

    public virtual double GetPace()
    {
        return 0; // Will be overridden
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_length} min) - " +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }

    protected int GetLength()
    {
        return _length;
    }
}