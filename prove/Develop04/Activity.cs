public class Activity
{
    protected int _time = 1;
    private string _title;
    private string _description;
    public Activity (string chosenActivity)
    {

        _title = chosenActivity;
        if(_title == "Breathing")
        {
            _description = "This activity will help you find more peace and less stress through breathing in and out slowly.\nFocus and prepare to begin.";
        }
        else if(_title == "Reflection")
        {
            _description = "This activity will help you refelct deeply on your past experiences.\nFocus and prepare to begin.";
        }
        else
        {
            _description = "This activity will help you reflect on your strengths by helping you list thing in a certain topic.\nFocus and prepare to begin.";
        }
    }

    public void Wait1Sec()
    {
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
    protected void DisplaySpinner(float time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        do
        {
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        }while(DateTime.Now < futureTime);


    }
    public void DisplayIntro()
    {
        Console.Clear();
        Console.Write($"Welcome to the {_title} Activity.\n\n{_description}\n\nHow long would you like this session to last in seconds?\n> ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
        Console.WriteLine("");

        
    }

    public void DisplayOutro()
    {
       Console.WriteLine("Great Job! Well done!!");
       DisplaySpinner(3);
       Console.WriteLine("");
       Console.WriteLine($"You have compleated {_time} seconds of the {_title} Activity.");
       DisplaySpinner(3); 
    }


}