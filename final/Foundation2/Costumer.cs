using System;
using System.Collections.Generic;

public class Customer
{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    public bool Location()
    {
        return _address.Location();
    }

    public string GetCostumerName()
    {
        return _name;
    }
    
    public Address GetCostumerAddress()
    {
        return _address;
    }
    

}