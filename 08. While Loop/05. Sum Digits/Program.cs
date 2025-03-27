int sum  = 0;

int number = int.Parse(Console.ReadLine());

while (number > 0)
{
    int lastdigit = number % 10;

    sum += lastdigit;

    number /= 10;


}

Console.WriteLine(sum);
