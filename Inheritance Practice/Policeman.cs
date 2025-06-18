class PoliceMan : Person
{

    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;
    public PoliceMan(string firstname, string lastname, int age, string weapons, int hoursworked, double hourlywage)
    : base(firstname, lastname, age) // This calls the constructor in the Base class. You can call any constructor.
    {
        _weapons = weapons;
        _hoursWorked = hoursworked;
        _hourlyWage = hourlywage;
    }

    public override string GetPersonInformation()
    {
        return $"I am a Policeman: Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override double GetPay()
    {
        double pay = _hourlyWage * _hoursWorked;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
    }


}