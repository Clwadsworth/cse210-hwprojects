public abstract class Activity
{
    private string _dateInput;
    private int _minRecorded;
    // main function
    public Activity(string date, int minutes)
    {
        _dateInput = date;
        _minRecorded = minutes;
    }

    public int GetMinutes()
    {
        return _minRecorded;
    }

    public string GetDate()
    {
        return _dateInput;
    }
    // provided from other classes
    public virtual double GetDistance()
    {
        return 0;
    }
    // provided from other classes
    public virtual double GetSpeed()
    {
        return 0;
    }
    // provided from other classes
    public virtual double GetPace()
    {
        return 0;
    }
    // needed to come from other classes
    // code help from https://essentialcsharp.com/home 
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetMinutes()} min): " +
        $"Distance {GetDistance():F1} miles" +
        $"Speed {GetSpeed():F1} mph, " +
        $"Pace {GetPace():F1} min per mile";
    }
}