int number = int.Parse(Console.ReadLine());

int result = 0;

for (int multiplier = 1; multiplier <=10; multiplier++)
{
    result = number * multiplier;

    Console.WriteLine($"{number} x {multiplier} = {result}");
}
