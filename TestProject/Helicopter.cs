public class Helicopter : Flyers
{
    private int _rotorDiameter;
    private int _rotorCount;

    public Helicopter(string name, int hp, int yr, int maxtakf, int rotorDiameter, int rotorCount)
        : base(name, hp, yr, 0, maxtakf)
    {
        _rotorDiameter = rotorDiameter;
        _rotorCount = rotorCount;
    }

    public override int CalcScore()
    {
        return 5 * _rotorDiameter + 50 * _rotorCount;
    }

    public override string Serialize()
    {
        return $"Helicopter#{_modelName}#{_horsePower}#{_year}#{_maxTakeOffWeight}#{_rotorDiameter}#{_rotorCount}";
    }
}
