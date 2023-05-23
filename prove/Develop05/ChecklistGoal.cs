using System;

public class ChecklistGoal : Goal
{
    int _timesToComplete;
    int _timesCompleted;

    public ChecklistGoal(bool complete, string name, int points, string type, int timesToComplete) : base(complete, name, points, type)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = 0;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalName} {_timesCompleted}/{_timesToComplete}");
    }

    public override int CompleteGoal()
    {
        _timesCompleted ++;
        if(_timesCompleted == _timesToComplete)
        {
            _isComplete = true;
            return (_pointValue * 2);
        }
        else
        {
        return _pointValue;
        } 
    }

public ChecklistGoal(string loadString):base()
    {
        string[] parts = loadString.Split("|");
        SetName(parts[0]);
        SetType(parts[1]);
        SetPoints(int.Parse(parts[2]));
        _timesToComplete = int.Parse(parts[4]);
        _timesCompleted = int.Parse(parts[5]);
        if (_timesCompleted == _timesToComplete)
        {
            SetComp(true);
        }
        else
        {
            SetComp(false);
        }
    }
    
    public override string GetLine()
{
    string line = $"{_isComplete}, {_goalName}, {_pointValue}, {_goalType}";
    return line;
}
}