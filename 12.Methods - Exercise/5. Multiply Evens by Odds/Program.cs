int number = Math.Abs(int.Parse(Console.ReadLine()));



Console.WriteLine(GetMultipleOfEvenAndOdds(number));


static int GetSumOfEvenDigits(int number)
{
    int evenSum = 0;

    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 == 0)
            evenSum += lastDigit;

        number /= 10;
    }

    return evenSum;

}

static int GetSumOfOddDigits(int number)
{
    int oddSum = 0;

    while (number > 0)
    {
        int lastDigit = number % 10;
        if (lastDigit % 2 != 0)
            oddSum += lastDigit;

        number /= 10;
    }

    return oddSum;

}


static int GetMultipleOfEvenAndOdds(int number)
{

    int evenSum = GetSumOfEvenDigits(number);
    int oddSum = GetSumOfOddDigits(number);

    return evenSum * oddSum;

}