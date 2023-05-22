using System.IO;
using System.Collections.Generic;

public class SimpleGoal : Goal
{


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

}


    
