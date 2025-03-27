int numbers = int.Parse(Console.ReadLine());

double numberBy2 = 0;
double numberBy3 = 0;
double numberBy4 = 0;

for (int i = 0; i < numbers; i++)

{
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        numberBy2++;
    }

    if (number % 3 == 0)
    {
        numberBy3++;
    }
      
    if (number % 4 == 0)
    {
        numberBy4++;
    }

}
double numberBy2Perc = (numberBy2 / numbers * 100);
double numberBy3Perc = (numberBy3 / numbers * 100);
double numberBy4Perc = (numberBy4 / numbers * 100);

Console.WriteLine($"{numberBy2Perc:F2}" + "%");
Console.WriteLine($"{numberBy3Perc:F2}" + "%");
Console.WriteLine($"{numberBy4Perc:F2}" + "%");