using System;
public class Entry
{
public string _date = "";
public string _prompt = "";
public string _content = "";

public Entry (string _date, string _prompt, string _content)
{
    this._date = _date;
    this._prompt = _prompt;
    this._content = _content;
}
public void DisplayEntry()
{
    Console.WriteLine($"{_date} \nPrompt: {_prompt}\nResponse: {_content}");
}

public string GetLine()
{
    string line = $"{_date} {_prompt} {_content}";
    return line;
}
}