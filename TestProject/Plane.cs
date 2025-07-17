using System.Reflection.Metadata.Ecma335;

public class Plane : Flyers
{
    public Plane(string Name, int hp, int yr, int maxwt)
        base("Plane", name, hp, yr, maxwt)
        {}

    string _landingGear;
    int _engineCount;

    private string GetLandingGear(string gear)
    {
        Console.WriteLine("Is this Land or Sea:");
        gear = Console.ReadLine();
        _landingGear = gear;
        return _landingGear ?? "N/A";
    }
    private void SetLandingGear(string gear)
    {
        _landingGear = gear;
    }

    private int GetEngines(int engines)
    {
        Console.WriteLine("Is this Land or Sea:");
        engines = int.Parse(Console.ReadLine());
        _engineCount = engines;
        return _engineCount;
    }
    private void SetEngines(int engines)
    {
        _engineCount = engines;
    }

    private override CalcScore()
    {
        int landinggearscore = 0;
        string lg = _landingGear.ToLower();
        if (string lg != "sea")
        {
            landinggearscore = 50;
        }
        else
        {
            landinggearscore = 0;
        }

        int EnginesScore = _engineCount * 10;
        int PlaneScore = landinggearscore + EnginesScore;
        return PlaneScore;
    }

}