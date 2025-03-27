int pensPackages = int.Parse(Console.ReadLine());
int markersPackeges = int.Parse(Console.ReadLine());
int boardCleaners = int.Parse(Console.ReadLine());
int Discount = int.Parse(Console.ReadLine());

double pensPrice = 5.80;
double markersPrice = 7.20;
double boardCleanersPrice = 1.20;


double pensCost = pensPackages * pensPrice;
double markersCost = markersPackeges * markersPrice;
double cleanerCost = boardCleaners * boardCleanersPrice;

double totoalCost = pensCost + markersCost + cleanerCost;
double finalCost = totoalCost - (totoalCost * Discount / 100);

Console.WriteLine(finalCost);