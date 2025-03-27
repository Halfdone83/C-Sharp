double puzzelPrice = 2.60;
double dollPrice = 3;
double bearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2;


double excursionPrice = double.Parse(Console.ReadLine());
double puzzelsAmount  = double.Parse(Console.ReadLine());
double dollsAmount  = double.Parse(Console.ReadLine());
double bearsAmount  = double.Parse(Console.ReadLine());
double minionsAmount  = double.Parse(Console.ReadLine());
double trucksAmount  = double.Parse(Console.ReadLine());

double toysCount = puzzelsAmount + dollsAmount + bearsAmount + minionsAmount + trucksAmount;

double toysCost = puzzelsAmount * puzzelPrice + 
                  dollsAmount* dollPrice +
                  bearsAmount* bearPrice +
                  minionsAmount* minionPrice +
                  trucksAmount * truckPrice;
        

if (toysCount > 50)
{
    toysCost *= 0.75;
}


double rentPrice = toysCost * 0.10;

double profit = toysCost - rentPrice;


if (profit > excursionPrice)
{
    double moneyLeft = profit - excursionPrice;
    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
}
else
{
    double moneyLeft = excursionPrice - profit;
    Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
}
