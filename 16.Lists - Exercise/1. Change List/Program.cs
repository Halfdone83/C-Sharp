List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


string input = Console.ReadLine();

while (input != "end")
{

    string[] commandParts = input.Split();

    string command = commandParts[0];
 

    if (command == "Delete")
    {
        int element = int.Parse(commandParts[1]);

        numbers.RemoveAll(n => n == element);

    }
    else if (command == "Insert")
    {
        int element = int.Parse(commandParts[1]);

        int positionToInstert = int.Parse(commandParts[2]);

        numbers.Insert(positionToInstert,element);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));