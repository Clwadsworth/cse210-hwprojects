public class Receptions : Event
{
    private string _rsvpEmail;
    
    public Receptions(string eventTitle, string description, string date, string time, string[] addressParts, string rsvpEmail) : base(eventTitle, description, date, time, addressParts)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetReceptionsDetails()
    {
        return $"{_rsvpEmail} had accepted the invite!"; 
    }
}