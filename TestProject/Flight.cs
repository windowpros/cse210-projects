public class Flight
{
    public Flyers FlyerUsed { get; set; }
    public int DurationMinutes { get; set; }
    public int Points => DurationMinutes + FlyerUsed.CalcScore();

    public Flight(Flyers flyer, int minutes)
    {
        FlyerUsed = flyer;
        DurationMinutes = minutes;
    }

    public override string ToString()
    {
        return $"Flight with {FlyerUsed.GetModel()}, Duration: {DurationMinutes} mins, Points: {Points}";
    }
}
