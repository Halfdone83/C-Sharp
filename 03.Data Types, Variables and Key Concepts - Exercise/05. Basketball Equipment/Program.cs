int annualFee = int.Parse(Console.ReadLine());

double sneakersPrice = annualFee * 0.60;
double uniformPrice = sneakersPrice * 0.80;
double ballsPrice = uniformPrice / 4;
double accessoariesPrice = ballsPrice / 5;


double totalMoneyNeeded = sneakersPrice + uniformPrice + ballsPrice + accessoariesPrice + annualFee;

Console.WriteLine(totalMoneyNeeded);