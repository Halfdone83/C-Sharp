List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();


while (input != "end")
{

    List<string>commandParts = input.Split().ToList();

    string command = commandParts[0];

    switch (command)
    {
        case "Add":

            int numberToAdd = int.Parse(commandParts[1]);
            numbers.Add(numberToAdd);

            break;

        case "Remove":
            int numberToRemove = int.Parse(commandParts[1]);
            numbers.Remove(numberToRemove);
            break;

        case "RemoveAt":

            int indexToRemove = int.Parse(commandParts[1]);
            numbers.RemoveAt(indexToRemove);

            break;

        case "Insert":
            int numberToInstert = int.Parse(commandParts[1]);
            int indexToAddAt = int.Parse(commandParts[2]);
            numbers.Insert(indexToAddAt, numberToInstert);  


            break;
    }



    input = Console.ReadLine();
}


Console.WriteLine(string.Join(" ", numbers));