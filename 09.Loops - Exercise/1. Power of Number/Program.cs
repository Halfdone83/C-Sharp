int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = 1;


for (int multiplier = 1; multiplier <= power; multiplier++)
{
    result *= number;
}

Console.WriteLine(result);