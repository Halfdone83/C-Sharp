

int commandCount = int.Parse(Console.ReadLine());


List<string> guestList = new List<string>();


for (int i = 0; i < commandCount; i++)
{

    string input = Console.ReadLine();

    List<string> commandParts = input.Split().ToList();

    string guestName = commandParts[0];

    if (commandParts.Count == 3)
    {

        if (guestList.Contains(guestName))
        {
            Console.WriteLine($"{guestName} is already in the list!");
        }
        else
        {
            guestList.Add(guestName);
        }

    }
    else if (commandParts.Count == 4)
    {
        if (!guestList.Contains(guestName))
        {
            Console.WriteLine($"{guestName} is not in the list!");

        }
        else
        {

            guestList.Remove(guestName);
        }

    }
}
foreach (string guestName in guestList)
{
    Console.WriteLine(guestName);
}
