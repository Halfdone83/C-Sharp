int number = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int numbers = 1; numbers <= number; numbers++)
{
    if (numbers != number)
    Console.Write(numbers + "+");
    else Console.Write(numbers + "=");

    totalSum += numbers;

}
Console.Write(totalSum);