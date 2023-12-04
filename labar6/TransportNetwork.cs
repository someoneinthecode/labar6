class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    // Додавання транспортного засобу до мережі
    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    // Розрахунок оптимального маршруту
    public void CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        Console.WriteLine($"Calculating optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}");
    }

    // Логіка посадки та висадки пасажирів
    public void BoardPassengers(Vehicle vehicle, int numberOfPassengers)
    {
        Console.WriteLine($"Boarding {numberOfPassengers} passengers into {vehicle.GetType().Name}");
    }

    public void DisembarkPassengers(Vehicle vehicle, int numberOfPassengers)
    {
        Console.WriteLine($"Disembarking {numberOfPassengers} passengers from {vehicle.GetType().Name}");
    }
}