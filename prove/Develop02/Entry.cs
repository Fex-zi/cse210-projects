using System;

//This is the public class Job syntax
public class Entry
{

    public string _date = "";

    public string _response = "";

    public string _prompt = "";
    //constructor
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
    
}