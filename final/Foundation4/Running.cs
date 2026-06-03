public class Running : Activity
{
    private double _distanceRan;
    // main function
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distanceRan = distance;
    }
    // all of our override statements needed for the activity class
    public override double GetDistance()
    {
        return _distanceRan;
    }

    public override double GetSpeed()
    {
        return (_distanceRan / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distanceRan;
    }
    // complete summary for running
    public override string GetSummary()
    {
        return $"{GetDate()} \nRan for: {GetMinutes()} \nFor a distance of: {GetDistance():F1} miles \nRunning at: {GetSpeed():F1} mph \nAt a pacing of: {GetPace():F1} minutes per mile";
    }
    
}