int number = int.Parse(Console.ReadLine());


PrintSignNumber(number);



static void PrintSignNumber(int n)
{
    if (n < 0)
    {
        Console.WriteLine($"The number {n} is negative.");
    }
    else if (n > 0)
    {
        Console.WriteLine($"The number {n} is positive.");
    }
    else
    {
        Console.WriteLine($"The number {n} is zero.");
    }

}