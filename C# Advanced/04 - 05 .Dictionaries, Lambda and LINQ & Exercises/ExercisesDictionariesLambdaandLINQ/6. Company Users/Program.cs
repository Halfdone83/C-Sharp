
Dictionary<string, List<string>>usersDatabase = new Dictionary<string, List<string>>();

while(true)
{
    string input = Console.ReadLine();
    
    if (input == "End")
    {
        break;
    }
    string[] data = input.Split("->");

    string companyName = data[0];
    string employeeId = data[1];

    if (usersDatabase.ContainsKey(companyName))
    {
        if (!usersDatabase[companyName].Contains(employeeId))
        {          
            usersDatabase[companyName].Add(employeeId);
        }
    }
    else
    {
        usersDatabase.Add(companyName, new List<string>() { employeeId });
    }
}
foreach (var kvp in usersDatabase)
{
    Console.WriteLine($"{kvp.Key}");

    foreach (var id in kvp.Value)
    {
        Console.WriteLine($"--{id}");
    }
 }