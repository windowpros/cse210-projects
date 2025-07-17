using System.Runtime.CompilerServices;

public class Helicopter : Flyers
{
    public Helicopter(string Name, int hp, int yr, int maxwt)
        base("Helicopter", name, hp, yr, maxwt)
        {}

    int _rotorDiameter;
    int _rotorCount;

    private int GetRotorDiameter(int diameter)
    {
        Console.WriteLine("Diameter: ");
        diameter = int.Parse(Console.ReadLine());
        _rotorDiameter = diameter;
        return _rotorDiameter;
    }
    private void SetRotorDiameter(int diameter)
    {
        _rotorDiameter = diameter;
    }
    private int GetRotorCount(int rc)
    {
        Console.WriteLine("Number of rotors: ");
        rc = int.Parse(Console.ReadLine());
        _rotorCount = rc;
        return _rotorCount;
    }

    private override CalcScore()
    {
        int HelicopterScore = 5 * _rotorDiameter + 50 * _rotorCount;
    }

}