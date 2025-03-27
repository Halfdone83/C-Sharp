int number = int.Parse(Console.ReadLine());

while (true)
{
    string command = Console.ReadLine();


    if (command == "Inc")
    {
        number += 1;
    }
    else if (command == "Dec")
    {
        number -= 1;
    }
    else
    {
        break;
    }
    
}

Console.WriteLine(number);