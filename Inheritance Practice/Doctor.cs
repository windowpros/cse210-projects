class Doctor : Person
{

    private string _tools;
    public Doctor(string firstname, string lastname, int age, string tools)
    : base(firstname, lastname, age) // This calls the constructor in the Base class. You can call any constructor.
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"Tools: {_tools} :: {GetPersonInformation()}";
    }
}