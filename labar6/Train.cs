class Train : Vehicle
{
    public int NumberOfWagons { get; set; }

    // Реалізація методу Move для поїзда
    public override void Move()
    {
        Console.WriteLine($"Train with {NumberOfWagons} wagons is moving");
    }
}