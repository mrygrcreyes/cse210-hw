public class Activity
{
    protected int _chosenTime = 1;
    private string _chosenActivity;
    private string _introduction;
    public Activity (string chosenActivity)
    {

        _chosenActivity = chosenActivity;
        if(_chosenActivity == "Breathing")
        {
            _introduction = "This activity will help you focus and relax by breathing in and out slowly.\nClear your mind and prepare to begin.";
        }
        else if(_chosenActivity == "Reflection")
        {
            _introduction = "This activity will help you refelct deeply on your past experiences.\nClear your mind and prepare to begin.";
        }
        else
        {
            _introduction = "This activity will help you reflect on the good things in your life by helping you list thing in a certain topic.\nClear your mind and prepare to begin.";
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
        Console.Write($"Welcome to the {_chosenActivity} Activity.\n\n{_introduction}\n\nApproximately how long would you like this session to last in seconds?\n> ");
        _chosenTime = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
        Console.WriteLine("");

        
    }

    public void DisplayOutro()
    {
       Console.WriteLine("Well done!!");
       DisplaySpinner(3);
       Console.WriteLine("");
       Console.WriteLine($"You have compleated {_chosenTime} seconds of the {_chosenActivity} Activity.");
       DisplaySpinner(3); 
    }


}