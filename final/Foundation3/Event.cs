using System;

public class Event
{
    private Address _address; 
    private string _date;
    private string _title;
    private string _time;
    private string _description;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetStandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.ToString()}";
    }


    public virtual string GetShortDescription()
    {
        return $"Event: {_title}\nDate: {_date}";
    }
}