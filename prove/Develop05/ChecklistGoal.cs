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
 
}