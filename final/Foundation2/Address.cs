public class Address
{
    // here is where we will 'hide' our information from the other classes
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //  here is our contructor for the address details 
    public Address(string streetaddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetaddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // this bool determines if the address is in the states or not
    public bool IsInUSA()
    {
        // adding a .upper to make sure whatever is imputted is read the same
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }

    // for this Get function we will organize the information into the address format
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}