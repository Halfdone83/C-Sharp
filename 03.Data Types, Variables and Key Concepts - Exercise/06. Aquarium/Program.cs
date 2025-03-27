int aquariumLength = int.Parse(Console.ReadLine());
int aquariumWidth = int.Parse(Console.ReadLine());
int aquariumHeigh = int.Parse(Console.ReadLine());

double occupiedCapacity = double.Parse(Console.ReadLine()) / 100;

double volumeCubic = aquariumHeigh * aquariumLength * aquariumWidth;

double volumeLeters = volumeCubic / 1000;

double occupiedLeters = volumeLeters * occupiedCapacity;

double letersNeeded = volumeLeters - occupiedLeters;

Console.WriteLine($"{letersNeeded:f2}");

