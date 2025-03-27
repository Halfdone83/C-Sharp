int nylonNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int thinnerNeeded = int.Parse(Console.ReadLine());
int hoursNeeded = int.Parse(Console.ReadLine());

double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5;

double nylonCost = nylonNeeded * nylonPrice;
double paintCost = paintNeeded * paintPrice;
double thinnerCost = thinnerNeeded * thinnerPrice;

double totalNylonCost = nylonCost + (nylonPrice * 2);
double totalPaintCost = paintCost + (paintCost * 0.10);
double bagsCost = 0.40;


double totalMaterialsCost = totalNylonCost + totalPaintCost + bagsCost + thinnerCost;

double hourPerWork = totalMaterialsCost * 0.30;
double totalHoursCost = hourPerWork * hoursNeeded;


Console.WriteLine(totalMaterialsCost + totalHoursCost);
