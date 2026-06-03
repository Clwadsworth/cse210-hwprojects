using System.Diagnostics.Contracts;

public class Cycling : Activity
{
    private double _speedInMph;
    // This is our main for the class
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speedInMph = speed;
    }
    //  all of overriding groups we need for activity class
    public override double GetSpeed()
    {
        return _speedInMph;
    }

    public override double GetDistance()
    {
        return (_speedInMph * GetMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedInMph;
    }
    // our main override for the summary call
    public override string GetSummary()
    {
        return $"{GetDate()} \nCycled for: {GetMinutes()} \nFor a distance of: {GetDistance():F1} miles \nMoving at: {GetSpeed():F1} mph \nAt a pacing of: {GetPace():F1} minutes per mile";;
    }
   
}