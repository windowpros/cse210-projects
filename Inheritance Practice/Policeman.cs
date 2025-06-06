class PoliceMan : Person
{

    private string _weapons;
    public PoliceMan(string firstname, string lastname, int age, string weapons)
    : base(firstname, lastname, age) // This calls the constructor in the Base class. You can call any constructor.
    {
        _weapons = weapons;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
}