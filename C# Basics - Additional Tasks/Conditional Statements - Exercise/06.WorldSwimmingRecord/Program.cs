double recordInSeconds = double.Parse(Console.ReadLine());
double distance  = double.Parse(Console.ReadLine());
double secondsPerMeter = double.Parse(Console.ReadLine());


double swimTime = distance * secondsPerMeter;

double additionalTime = Math.Floor(distance / 15) * 12.5;

double totalSwimTime = swimTime + additionalTime;

if (totalSwimTime < recordInSeconds)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {totalSwimTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {totalSwimTime - recordInSeconds:F2} seconds slower.");
}
