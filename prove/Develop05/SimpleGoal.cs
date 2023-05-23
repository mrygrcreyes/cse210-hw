using System;


public class SimpleGoal : Goal
{
    
 public SimpleGoal(string loadString)
    {
        string[] parts = loadString.Split("|");
        SetName(parts[0]);
        SetType(parts[1]);
        SetPoints(int.Parse(parts[2]));
        if (int.Parse(parts[3])==1)
        {
            SetComp(true);
        }
        else if (int.Parse(parts[3])==0)
        {
            SetComp(false);
        }
    }

    
    public SimpleGoal(int points, bool complete, string name, string type) : base(complete, name, points, type)
    {
    }


    public override void DisplayGoal()
    {
       string icon;
       if(_isComplete)
       {
        icon = "[x]";
       } 
       else
       {
        icon = "[ ]";
       }
       Console.WriteLine($"{_goalName} {icon}");
    }

    public override int CompleteGoal()
    {
        _isComplete = true;
        return _pointValue;
    }
    
    public override string GetLine()
{
    string line = $"{_isComplete}, {_goalName}, {_pointValue}, {_goalType}";
    return line;
}

}


    
