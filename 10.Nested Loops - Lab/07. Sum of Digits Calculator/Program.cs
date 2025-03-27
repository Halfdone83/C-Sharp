
string input = Console.ReadLine();



while (input != "End")
{
    int sum = 0;
    int number = int.Parse(input);

    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;

    }
    Console.WriteLine($"Sum of digits = {sum}");

    input = Console.ReadLine();

}

Console.WriteLine("Goodbye");