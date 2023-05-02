using System.IO;
using System.Collections.Generic;
public class Entry
{
public string _date = "";
public string _prompt = "";
public string _response = "";

public Entry(string _date, string _prompt, string _response)
{
    this._date = _date;
    this._prompt = _prompt;
    this._response = _response;
}
public void DisplayEntry()
{
    Console.WriteLine($"{_date} \nPrompt: {_prompt}\nResponse: {_response}");
}

public string GetLine()
{
    string line = $"{_date}, {_prompt}, {_response}";
    return line;
}
}