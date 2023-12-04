class Bus : Vehicle
{
    public int NumberOfSeats { get; set; }

    // Реалізація методу Move для автобуса
    public override void Move()
    {
        Console.WriteLine($"Bus with {NumberOfSeats} seats is moving");
    }
}