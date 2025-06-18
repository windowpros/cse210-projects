class Doctor : Person
{

    private string _tools;
    private double _salary;
    public Doctor(string firstname, string lastname, int age, string tools, double salary)
    : base(firstname, lastname, age) // This calls the constructor in the Base class. You can call any constructor.
    {
        _tools = tools;
        _salary = salary;
    }

    public override string GetPersonInformation()
    {
        return $"I am a Doctor: Tools: {_tools} :: {base.GetPersonInformation()}";
    }

    public override double GetPay()
    {
        return _salary / 12;
    }
}