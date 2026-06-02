public class OutdoorGatherings : Event
{
    private string _weatherForcast;

    public OutdoorGatherings(string eventTitle, string description, string date, string time, string[] addressParts, string weatherForcast) : base(eventTitle, description, date, time, addressParts)
    {
        _weatherForcast = weatherForcast;
    }

    public string GetOutdoorDetails()
    {
        return $"{_weatherForcast}";
    }
}