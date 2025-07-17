abstract class Flyers
{
    private string _modelName;
    private int _horsePower;
    private int _year;
    private int _hourlyScore;
    private int _maxTakeOffWeight;

    public Flyers(string name, int hp, int yr, int hrlyscore, int maxtakf)
    {
        _modelName = name;
        _horsePower = hp;
        _year = yr;
        _hourlyScore = hrlyscore;
        _maxTakeOffWeight = maxtakf;
    }

    public Flyers() { }

    private string GetModel(string name)
    {
        Console.WriteLine("Model: ");
        name = Console.ReadLine();
        _modelName = name;
        return _modelName ?? "N/A";
    }
    private void SetModel(string name)
    {
        _modelName = name;
    }
    private int GetHorsePower(int hp)
    { 
        Console.WriteLine("Horse Power: ");
        hp = int.Parse(Console.ReadLine());
        _horsePower = hp;
        return _horsePower;
    }
    private void SetHorsePower(int hp)
    {
        _horsePower = hp;
    }
    private int GetYear(int yr)
    { 
        Console.WriteLine("Horse Power: ");
        yr = int.Parse(Console.ReadLine());
        _year = yr;
        return _year;
    }
    private void SetYear(int yr)
    {
        _year = yr;
    }
    private int GetMaxTakeOffWeight(int maxwt)
    { 
        Console.WriteLine("Horse Power: ");
        maxwt = int.Parse(Console.ReadLine());
        _maxTakeOffWeight = maxwt;
        return _maxTakeOffWeight;
    }
    private void SetMaxTakeOffWeight(int mxwgt)
    {
        _maxTakeOffWeight = mxwgt;
    }
    private abstract CalcScore();
    


    

}