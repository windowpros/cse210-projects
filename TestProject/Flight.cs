public class Flight
{
    private Flyers FlyerUsed { get; set; }
    private int DurationMinutes { get; set; }
    private int Points => DurationMinutes + FlyerUsed.CalcScore();

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
