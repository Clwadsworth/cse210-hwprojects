public class Lectures : Event
{
    // we are holding the info for the lectures and who how many attended
    private string _speakerName;
    private int _capacity;

    public Lectures(string eventTitle, string description, string date, string time, string[] addressParts, string speakerName, int capacity) : base(eventTitle, description, date, time, addressParts)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetLuctureDetails()
    {
        return $"{_speakerName} with attendance of {_capacity}";
    }
}