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
    public abstract void DisplayGoal();

    public abstract int CompleteGoal();

    public new string GetType()
    {
        return _goalType;
    }
}