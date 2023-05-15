public class BreathingActivity : Activity
{
    public BreathingActivity(string chosenActivity) :base(chosenActivity)
    {

    }

    public void DoBreath()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        do
        {
            Console.Write("Breathe in...");
            Console.Write("4");
            Wait1Sec();
            Console.Write("3");
            Wait1Sec();
            Console.Write("2");
            Wait1Sec();
            Console.Write("1");
            Wait1Sec();
            Console.WriteLine(" ");
            Console.Write("Now breath out...");
            Console.Write("6");
            Wait1Sec();
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
            Console.WriteLine(" ");
            Console.WriteLine("");
        }while(DateTime.Now < futureTime);
    }
}