int firstNum = 1;
int lastNum = int.Parse(Console.ReadLine());

for (int number = 1; number <= lastNum; number = number * 2 +1)
{

    Console.WriteLine(number);
}