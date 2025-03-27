double budget = double.Parse(Console.ReadLine());
int ppl = int.Parse(Console.ReadLine());
double clothingPrice  = double.Parse(Console.ReadLine());

double decorPrice = budget * 0.10;

double clothesCost = clothingPrice * ppl;

if (ppl > 150)
{
    clothesCost *= 0.90; 
}

double totoalMovieCost = decorPrice + clothesCost;

if  (totoalMovieCost > budget)
{
    double moneyLeft = totoalMovieCost - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyLeft:f2} leva more.");
}

else
{
    double moneyLeft = budget - totoalMovieCost;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}