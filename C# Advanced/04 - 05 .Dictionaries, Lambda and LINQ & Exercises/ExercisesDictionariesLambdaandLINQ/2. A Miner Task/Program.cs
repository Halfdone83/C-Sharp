string resource = Console.ReadLine();

int quantity = 0;


Dictionary<string, int>resources = new Dictionary<string, int>();


while (true)
{
    if (resource == "stop")
        { break; }

    quantity = int.Parse(Console.ReadLine());

    if (resources.ContainsKey(resource))
    {

        resources[resource] += quantity;
    }
    else
    {
        resources.Add(resource, quantity);

    }


    resource = Console.ReadLine();
    

}

foreach (var kvp in resources)
{

    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

}