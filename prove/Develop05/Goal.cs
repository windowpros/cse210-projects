using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Authentication.ExtendedProtection;

class Goal
{
    string _goalType;
    string _goalName;
    string _goalDiscription;
    int _numberOfPoints;
    bool _status;

    protected Goal()
    {

    }

    protected Goal(string type, string name, string discription, int points, bool status)
    {
        _goalType = type;
        _goalName = name;
        _goalDiscription = discription;
        _numberOfPoints = points;
        _status = status;
    }

    private string GetName()
    {
        return _goalName;
    }
    private string GetType()
    {
        return _goalType;
    }
    private string GetDiscription()
    {
        return _goalDiscription;
    }
    private int GetPoints()
    {
        return _numberOfPoints;
    }
    private bool GetStatus()
    {
        return _status;
    }

    public virtual string DisplayGoal()
    {
        return $"Type: {_goalType}, Name: {_goalName}, Description: {_goalDiscription}, Points: {_numberOfPoints}, Status: {_status}";
    }

   

}