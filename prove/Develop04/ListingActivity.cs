public class ListingActivity : Activity
{
    List<string> _promptList = new List<string>{
        {"Who are people that you appreciate?"},
        {"What are personal strengths of yours?"},
        {"Who are people that you have helped this week?"},
        {"When have you felt the Holy Ghost this month?"},
        {"Who are some of your personal heroes?"}
    };
    List<string> _usedPrompts = new List<string>();
    List<string> _responseList = new List<string>();
    public ListingActivity(string chosenActivity) :base(chosenActivity)
    {
        
    }

    private void ClearIfAllUsed()
    {
        if(_usedPrompts.Count == _promptList.Count)
        {
            _usedPrompts.Clear();
        }
    }

    private string GetPrompt()
    {
        ClearIfAllUsed();
        Random rnd = new Random();
        int index = rnd.Next(_promptList.Count);
        string prompt = _promptList[index];
        while(_usedPrompts.Contains(prompt))
        {
            index = rnd.Next(_promptList.Count);
            prompt = _promptList[index];
        }
        _usedPrompts.Add(prompt);
        return(prompt);
    }

    public void DoListing()
    {
       _responseList.Clear();
       string prompt = GetPrompt();
       Console.Write($"List as many responses as you can to the following prompt:\n\n---{prompt}---\n\n");
       Console.Write("You may begin in: ");
       Console.Write("5");
       Wait1Sec();
       Console.Write("4");
       Wait1Sec();
       Console.Write("3");
       Wait1Sec();
       Console.Write("2");
       Wait1Sec();
       Console.Write("1");
       Wait1Sec();
       Console.WriteLine("");
       DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(_time);
       do
       {
        Console.Write("> ");
        string response = Console.ReadLine();
        _responseList.Add(response);
       }while(DateTime.Now < futureTime);
       Console.WriteLine($"You listed {_responseList.Count} Items!");
       Console.WriteLine("");
    }
}