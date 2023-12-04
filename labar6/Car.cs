class Car : Vehicle
{
    public string Model { get; set; }

    // Реалізація методу Move для автомобіля
    public override void Move()
    {
        Console.WriteLine($"Car {Model} is moving");
    }
}