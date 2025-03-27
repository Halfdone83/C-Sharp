string serialName = Console.ReadLine();
int serialDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchTime = breakDuration / 8.0;
double restTime = breakDuration / 4.0;
double breakLeft = breakDuration - lunchTime - restTime;


if (serialDuration <= breakLeft)
{
    Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(breakLeft - serialDuration)} minutes free time.");
}

else
{
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(serialDuration - breakLeft)} more minutes.");
}
