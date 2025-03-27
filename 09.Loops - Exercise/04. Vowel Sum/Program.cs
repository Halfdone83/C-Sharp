
int characters = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int i = 1; i <= characters; i++)
{
    char character = char.Parse(Console.ReadLine());

    if (character == 'a')
    {
        int value = 1;

        totalSum += value;
    }
    else if (character == 'e')
    {
        int value = 2;

        totalSum += value;
    }

    else if (character == 'i')
    {
        int value = 3;

        totalSum += value;
    }

    else if (character == 'o')
    {
        int value = 4;

        totalSum += value;
    }


    else if (character == 'u')
    {
        int value = 5;

        totalSum += value;
    }
    else
    {
        int value = 0;

        totalSum += value;
    }

}

Console.WriteLine(totalSum);