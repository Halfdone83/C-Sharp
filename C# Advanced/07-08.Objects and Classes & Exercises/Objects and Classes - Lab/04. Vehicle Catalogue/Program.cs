using System.Reflection;
string[] input = Console.ReadLine().Split("/");

Catalog catalog = new Catalog();

while (input[0] != "end")
{
    string type = input[0];
    string brand = input[1];
    string model = input[2];

    if (type == "Car")
    {
        int horsePowers = int.Parse(input[3]);
        Car currentCar = new Car(brand, model, horsePowers);

       catalog.Cars.Add(currentCar);
    }
    else
    {
        double weight = double.Parse(input[3]);
        Truck currentTruck = new Truck(brand, model, weight);

        catalog.Trucks.Add(currentTruck);
    }

    input = Console.ReadLine().Split("/");
}

if (catalog.Cars.Count > 0)
{

    Console.WriteLine("Cars:");

    foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

if (catalog.Trucks.Count > 0)
{
    Console.WriteLine("Trucks:");


    foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}

class Truck
{
    public Truck(string brand, string model, double weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
    public string Brand { get; set; }

    public string Model { get; set; }

    public double Weight { get; set; }
}

class Car
{
    public Car(string brand, string model, int horsePowers)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePowers;
    }
    public string Brand { get; set; }

    public string Model { get; set; }

    public int HorsePower { get; set; }
}

class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }


}