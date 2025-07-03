public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base("Simple Goal", name, description, points)
    {
    }

    public override string GetName()
    {
        return "SimpleGoal: " + base.GetName();
    }

    public override void SetName(string name)
    {
        base.SetName(name.ToUpper());
    }
}
