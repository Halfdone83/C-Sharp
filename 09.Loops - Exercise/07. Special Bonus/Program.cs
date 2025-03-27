int stopNumber = int.Parse(Console.ReadLine());

int currentNumber = 0;


int tempNumber = 0;

while (currentNumber != stopNumber)
{
    tempNumber = currentNumber;
    currentNumber = int.Parse(Console.ReadLine());
    

}

Console.WriteLine(tempNumber * 1.2);