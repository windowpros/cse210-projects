public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base("Eternal Goal", name, description, points)
    {
    }

    public override string GetName()
    {
        return "EternalGoal: " + base.GetName();
    }

    public override int RecordEvent()
    {
        // Never completes
        return GetPoints();
    }

    public override string GetDisplayString()
    {
        return $"[~] {GetName()} ({GetDescription()})";
    }
}
