public class EternalGoal : Goal
{
    int _timesCompleted;
    public EternalGoal(string name, int points, string type, bool complete) : base(complete, name, points, type)
    {
        _timesCompleted = 0; 
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


}