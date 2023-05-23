using System;

public class EternalGoal : Goal
{
    int _timesCompleted;

    public EternalGoal(string name, int points, string type, bool complete) : base(complete, name, points, type)
    {
        _timesCompleted = 0; 
    }
    public EternalGoal(string loadString) 
    {
        string[] parts = loadString.Split("|");
        SetName(parts[0]);
        SetType(parts[1]);
        SetPoints(int.Parse(parts[2]));
        SetComp(false);
        _timesCompleted = int.Parse(parts[3]);
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalName} [{_timesCompleted}]");
    }

    public override int CompleteGoal()
    {
         _timesCompleted ++;
        if(_timesCompleted % 10 == 0)
        {
            return (_pointValue * 2);
        }
        else
        {
            return _pointValue;
        }
       
    }
    public override string GetLine()
{
    string line = $"{_isComplete}, {_goalName}, {_pointValue}, {_goalType}";
    return line;
}
    

}