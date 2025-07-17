public class Plane : Flyers
{
    private string _landingGear;
    private int _engineCount;

    public Plane(string name, int hp, int yr, int maxtakf, string landingGear, int engineCount)
        : base(name, hp, yr, 0, maxtakf)
    {
        _landingGear = landingGear;
        _engineCount = engineCount;
    }

    public override int CalcScore()
    {
        int landingGearScore = _landingGear.ToLower() == "land" ? 50 : 0;
        int engineScore = _engineCount * 10;
        return landingGearScore + engineScore;
    }

    public override string Serialize()
    {
        return $"Plane#{_modelName}#{_horsePower}#{_year}#{_maxTakeOffWeight}#{_landingGear}#{_engineCount}";
    }
}
