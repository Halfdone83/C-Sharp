string command = Console.ReadLine();


Dictionary<string, List<double>>productList = new Dictionary<string, List<double>>();

while (command != "buy")
{
    
    string[] commandParts = command.Split();

    string product = commandParts[0];
    double price = double.Parse(commandParts[1]);
    double quantity = double.Parse(commandParts[2]);

    

    if (productList.ContainsKey(product) )
    {

        productList[product][0] = price;
        productList[product][1] += quantity;
    }
    else
    {

        productList.Add(product, new List<double> { price, quantity });
    }

    command = Console.ReadLine();

}

foreach (var kvp in productList)
{
    Console.WriteLine($"{kvp.Key:F2} -> {kvp.Value[0] * kvp.Value[1]:F2}");

}