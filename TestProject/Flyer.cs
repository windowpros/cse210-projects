public abstract class Flyers
{
    protected string _modelName;
    protected int _horsePower;
    protected int _year;
    protected int _hourlyScore;
    protected int _maxTakeOffWeight;

    public Flyers(string name, int hp, int yr, int hrlyscore, int maxtakf)
    {
        _modelName = name;
        _horsePower = hp;
        _year = yr;
        _hourlyScore = hrlyscore;
        _maxTakeOffWeight = maxtakf;
    }

    public Flyers() {}

    public string GetModel() => _modelName;
    public abstract int CalcScore();
    public abstract string Serialize();
}
