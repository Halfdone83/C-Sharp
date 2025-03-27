
int startNumber = int.Parse(Console.ReadLine());
int endNumber  = int.Parse(Console.ReadLine());


for (int number = startNumber; number <= endNumber; number++)
{
    int counter = 0;

    for (int del = 1; del <= number; del++)
    {
        if (number % del == 0)
        {
            counter++;
        }
    }
    if (counter == 2)

        {

            Console.Write(number + " ");
        }
    }
