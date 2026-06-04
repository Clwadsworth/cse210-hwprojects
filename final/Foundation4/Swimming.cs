public class Swimming : Activity
{
    private int _lapsSwam;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _lapsSwam = laps;
    }

    public override double GetDistance()
    {
        return _lapsSwam * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}