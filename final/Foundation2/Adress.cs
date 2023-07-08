using System;
using System.Collections.Generic;

public class Address
{
    private string _country;
    private string _street;
    private string _city;
    private string _state;

    
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool Location()
    {
        return _country == "United States";
    }
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
    

}