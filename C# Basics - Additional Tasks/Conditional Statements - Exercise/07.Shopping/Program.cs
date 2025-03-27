double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int proccessors  = int.Parse(Console.ReadLine());
int rams = int.Parse(Console.ReadLine());

int videoCardsPrice = 250;

double videoCardsCost = videoCards * videoCardsPrice;

double proccessorsPrice = videoCardsCost * 0.35;
double ramsPrice = videoCardsCost * 0.10;

double proccessorsCost = proccessorsPrice * proccessors;
double ramsCost = ramsPrice * rams;

double totoalCost = proccessorsCost + ramsCost + videoCardsCost;

if (videoCards > proccessors)
{
    totoalCost *= 0.85;
}


if (budget >= totoalCost)
{
    Console.WriteLine($"You have {budget - totoalCost:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {totoalCost - budget:F2} leva more!");
}