int counter = int.Parse(Console.ReadLine());

Dictionary<string, string>parkingRegister = new Dictionary<string, string>();

for (int i = 0; i < counter; i++)
{
    string input = Console.ReadLine();

    string[] data = input.Split();
    string command = data[0];
    string name = data[1];
    
    if (data[0] == "register")
    {
        string plate = data[2];

        if (parkingRegister.ContainsKey(name))
        {
            Console.WriteLine($"ERROR: already registered with plate number {plate}");
        }
        else
        {
            parkingRegister.Add(name, plate);
            Console.WriteLine($"{name} registered {plate} successfully");
        }
    }
    else if(data[0] =="unregister")
    {
        if (parkingRegister.ContainsKey(name))
        {
            parkingRegister.Remove(name);
            Console.WriteLine($"{name} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }
    }
}
foreach  (var kvp in parkingRegister)
{

   Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}