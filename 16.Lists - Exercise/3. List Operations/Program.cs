List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "End")
{
    List<string> commandParts = input.Split().ToList();

    string command = commandParts[0];   
   
    switch (command)
    {
        case "Add":
            int numberToAdd = int.Parse(commandParts[1]);
            numbers.Add(numberToAdd);
            break;

        case "Insert":
            int numberToInsert = int.Parse(commandParts[1]);
            int indexToInsertTo = int.Parse(commandParts[2]);

            if (indexToInsertTo >= 0 && indexToInsertTo < numbers.Count)
            {
                numbers.Insert(indexToInsertTo, numberToInsert);       
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;

        case "Remove":
            int indexToRemove = int.Parse(commandParts[1]);

            if (indexToRemove >= 0 && indexToRemove < numbers.Count)
            {
                numbers.RemoveAt(indexToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;
            
        case "Shift":
            string direction = commandParts[1];

            if (direction == "left")
            {
                for (int i = 0; i < int.Parse(commandParts[2]); i++)
                {
                    int firstNum = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(firstNum);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < int.Parse(commandParts[2]); i++)
                {
                    int lastNum = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, lastNum);

                }
            }
             break;     
    }

input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));

