public class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _numberOfPoints;
    private bool _status;

    public Goal() { }

    public Goal(string type, string name, string description, int points)
    {
        _goalType = type;
        _goalName = name;
        _goalDescription = description;
        _numberOfPoints = points;
        _status = false;
    }

    public virtual string GetName()
    {
        return _goalName;
    } 

    public virtual void SetName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            _goalName = name;
        }
    }

    public virtual string GetDescription()
    {
        return _goalDescription;
    }

    public virtual void SetDescription(string description)
    {
        if (!string.IsNullOrWhiteSpace(description))
        {
            _goalDescription = description;
        }
    }

    public virtual int GetPoints()
    {
        return _numberOfPoints;
    } 

    public virtual void SetPoints(int points)
    {
        if (points >= 0)
        {
            _numberOfPoints = points;
        }
    }

        public virtual string GetGoalType()
    {
        return _goalType;
    }

    public virtual void SetGoalType(string type)
    {
        _goalType = type;
    }

    public virtual bool GetStatus()
    {
        return _status;
    }

    public virtual void SetStatus(bool status)
    {
        _status = status;
    }


    public virtual int RecordEvent()
    {
        _status = true;
        return _numberOfPoints;
    }

    public virtual string GetDisplayString()
    {
        string statusString = _status ? "[X]" : "[ ]";
        return $"{statusString} {_goalName} ({_goalDescription})";
    }
}
