using System.IO;
using System.Collections.Generic;
public class Journal
{
   public List<Entry> _entries = new List<Entry>(); 

   public void DisplayJournal()
   {
    foreach (Entry entry in _entries)
    {
        entry.DisplayEntry();
    }
   }

    public string GetResponse(string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        return response;

    }
    public string SaveFileName(string type)
    {   
        if (type == "save")
        {
            Console.Write("Name your file: ");
        }
        else
        {
            Console.Write("Load what file?: ");
        }
        
        string fileName = Console.ReadLine();
        return fileName;
    }

   public void SaveJournal()
   {
    string fileName = SaveFileName("save");

    using ( StreamWriter saveFile = new StreamWriter(fileName))
    {
        foreach(Entry entry in _entries)
        {
            string line = entry.GetLine();
            saveFile.WriteLine(line);           
        }
    }
   }

   public void LoadJournal()
   {
    _entries.Clear();
    string fileName = SaveFileName("load");
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        string[] parts = line.Split(",");
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
    }
   }
    public void CreateEntry()
   {
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    Prompts promptGen = new Prompts();
    string prompt = promptGen.ChooseRandomPrompt();
    string response = GetResponse(prompt);

    Entry entry = new Entry(dateText, prompt, response);
    _entries.Add(entry);
   }
}