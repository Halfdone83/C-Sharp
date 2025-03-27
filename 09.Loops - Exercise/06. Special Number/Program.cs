int number = int.Parse(Console.ReadLine());

int tempNum = number;

bool isSpecail = true;

while (tempNum > 0)
{
    int lastDigit = tempNum % 10;

    tempNum = tempNum / 10;

    if (number % lastDigit != 0)
    {
        isSpecail = false;
        break;

    }

}

if  (isSpecail)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}