using System.Data;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Security.Authentication;

public class Event
{
    // Have our information that is for all classes stored here
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    // the class of address allows me to insert a nested class
    private class Address
    {
        public Address(string[] arguments)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                _ = i switch
                {
                    0 => Street = arguments[0].ToLower(),
                    1 => City = arguments[1].ToLower(),
                    2 => State = arguments[2].ToLower(),
                    3 => ZipCode = arguments[3].ToLower(),
                    4 => Country = arguments[4].ToLower(),
                    _ => throw new ArgumentException($"Unexpected argument " + $"'{arguments[i]}'")
                };
            }
        }
        // additional attributtes that help flesh out the GetAddress()
        public string? Street { get; }
        public string? City { get; }
        public string? State { get; }
        public string? ZipCode { get; }
        public string? Country { get; }

        public string GetAddress()
        {
            return $"{Street}, {City}, {State} {ZipCode}, {Country}";
        }

    }
    // https://essentialcsharp.com/nested-classes

    public Event(string eventTitle, string description, string date, string time, string[] addressParts)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(addressParts);
    }

    public string GetStandardDetails()
    {
        return $"{_eventTitle}: at {_date}-{_time}: {_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"{_description}";
    }
}