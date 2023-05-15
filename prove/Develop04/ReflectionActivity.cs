public class ReflectionActivity : Activity
{
    List<string> _promptList = new List<string>{
            {"Think of a time when you stood up for someone else."},
            {"Think of a time when you did something really difficult."},
            {"Think of a time when you helped someone in need."},
            {"Think of a time when you did something truly selfless."}
        };
    List<string> _questionList = new List<string>{
            {"Why was this experience meaningful to you?"},
            {"Have you ever done anything like this before?"},
            {"How did you get started?"},
            {"How did you feel when it was complete?"},
            {"What made this time different than other times when you were not as successful?"},
            {"What is your favorite thing about this experience?"},
            {"What could you learn from this experience that applies to other situations?"},
            {"What did you learn about yourself through this experience?"},
            {"How can you keep this experience in mind in the future?"}
        };
    List<string> _usedPrompts = new List<string>();
    List<string> _usedQuestions = new List<string>();
    public ReflectionActivity(string chosenActivity) :base(chosenActivity)
    {

    }

    private void ClearIfAllUsed()
    {
        if(_usedPrompts.Count == _promptList.Count)
        {
            _usedPrompts.Clear();
        }
        if(_usedQuestions.Count == _questionList.Count)
        {
            _usedQuestions.Clear();
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

    private string GetQuestion()
    {
        ClearIfAllUsed();
        Random rnd = new Random();
        int index = rnd.Next(_questionList.Count);
        string question = _questionList[index];
        while(_usedQuestions.Contains(question))
        {
            index = rnd.Next(_questionList.Count);
            question = _questionList[index];
        }
        _usedQuestions.Add(question);
        return(question);
    }

    public void DoReflect()
    {
       string prompt = GetPrompt();
       string question1 = GetQuestion();
       string question2 = GetQuestion();
       float spinTime = _time/2;

       Console.Write($"Consider the following prompt:\n\n---{prompt}---\n\nWhen you have something in mind, press enter to coninue.");
       Console.ReadLine();
       Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
       Console.Write("You may begin in :");
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
       Console.Clear();
       Console.Write($">{question1}");
       DisplaySpinner(spinTime);
       Console.WriteLine(" ");
       Console.Write($">{question2}");
       DisplaySpinner(spinTime);
       Console.WriteLine(" ");
       Console.WriteLine("");


    }
}

  
