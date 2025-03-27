using System.Runtime.CompilerServices;

int number = int.Parse(Console.ReadLine());

int currentNum = 1;

for (int line = 1; line <= number; line++)
{

    for (int row = 1; row <= line; row++)

    {
        Console.Write(currentNum + " ");
        currentNum++;
        if (currentNum > number)
        {
            break;
        }

    }
    Console.WriteLine();
    if (currentNum > number)
    {
        break;
    }
}
