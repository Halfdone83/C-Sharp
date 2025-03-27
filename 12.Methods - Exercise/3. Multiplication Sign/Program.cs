
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());


NumberSign(number1, number2, number3);

static void NumberSign(int number1, int number2, int number3)
{

    if (number1 == 0 || number2 == 0 || number3 == 0)

    {
        Console.WriteLine("zero");
        return;
    }

    int negaviteCount = 0;

    if (number1 < 0) negaviteCount++;
    if (number2 < 0) negaviteCount++;
    if (number3 < 0) negaviteCount++;


    if (negaviteCount % 2 == 0)
    {
        Console.WriteLine("positive");
    }

    else

    {
        Console.WriteLine("negative");
    }

}