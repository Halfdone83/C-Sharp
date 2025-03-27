double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileW = double.Parse(Console.ReadLine());
double tileH = double.Parse(Console.ReadLine());



double bathroomArea = bathroomHeight * bathroomWidth;
double tileArea = tileH * tileW;


double bathroomSurplusArea = bathroomArea * 1.10;

double tilesNeded = bathroomSurplusArea / tileArea;

Console.WriteLine(Math.Round(tilesNeded));
