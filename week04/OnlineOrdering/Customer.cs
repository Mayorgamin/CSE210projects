using System;

class Customer
{
    // Fields
    private string _name;
    private Address _address;
    // Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    // Methods
    public string GetCustomerName()
    {
        return _name;
    }
    public bool IsCustomerInUSA()
    {
        return _address.IsUSA();
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}



