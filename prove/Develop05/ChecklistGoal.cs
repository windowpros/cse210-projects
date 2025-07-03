public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base("Checklist Goal", name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount)
        {
            SetStatus(true);
            return GetPoints() + _bonusPoints;
        }
        else
        {
            return GetPoints();
        }
    }

    public override string GetDisplayString()
    {
        string statusString = GetStatus() ? "[X]" : "[ ]";
        return $"{statusString} {GetName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

        public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }

}
