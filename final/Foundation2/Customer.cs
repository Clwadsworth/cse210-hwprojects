public class Customer
{
    private string _name;
    // Address confirms that a customer has an address
    private Address _address;

    // Building out the constructor to locate the data upon creation
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // this Get funciton will allow the other classes to get the information without overwriting it
    public string GetCustomerName()
    {
        return _name;
    }

    //  passes to the internal Address object
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // asks the Address object to reutrn the formatting
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}