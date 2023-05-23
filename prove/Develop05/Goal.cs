using System;

public abstract class Goal
{
    protected bool _isComplete;
    protected string _goalName;
    protected int _pointValue;
    protected string _goalType;

    public Goal(bool complete, string name, int points, string type)
    {
       _isComplete = complete;
       _goalName = name; 
       _pointValue = points;
       _goalType = type;
    }

    protected Goal()
    {
    }

    public new string GetType()
    {
        return _goalType;
    }

        public void SetName(string name)
    {
        _goalName = name;
    }
    public void SetPoints(int points)
    {
        _pointValue = points;
    }
    public void SetComp(bool complete)
    {
        _isComplete = complete;
    }
    public void SetType(string type)
    {
        _goalType = type;
    }
    public int GetPoints()
    {
        return _pointValue;
    }
    public string GetName()
    {
        return _goalName;
    }

    public virtual string GetLine()
    {
        string line = $"{_isComplete}, {_goalName}, {_pointValue}, {_goalType}";
        return line;
    }

    public abstract void DisplayGoal();
    public abstract int CompleteGoal();

}