class Program
{
    static void Main()
    {
        // Приклад використання класів
        Car car = new Car { Model = "Toyota", Speed = 120, Capacity = 4 };
        Bus bus = new Bus { NumberOfSeats = 30, Speed = 80, Capacity = 30 };
        Train train = new Train { NumberOfWagons = 5, Speed = 100, Capacity = 200 };

        TransportNetwork transportNetwork = new TransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        Route route = new Route { StartPoint = "City A", EndPoint = "City B" };

        foreach (var vehicle in transportNetwork)
        {
            vehicle.Move();
            transportNetwork.CalculateOptimalRoute(route, vehicle);
            transportNetwork.BoardPassengers(vehicle, 50);
            transportNetwork.DisembarkPassengers(vehicle, 20);
        }
    }
}
