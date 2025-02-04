using System;

class Address
{
    // Fields
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    // Methods
    public bool IsUSA()
    {
        return _country == "USA";
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}


