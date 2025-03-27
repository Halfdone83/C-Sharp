using System;

int number = int.Parse(Console.ReadLine());

double additionalNumbersSum = 0;

for (int numbers = 1; numbers <= number; numbers++)
{

    double additionalNumber = double.Parse(Console.ReadLine());
    additionalNumbersSum += additionalNumber;
    

}
Console.WriteLine(additionalNumbersSum);