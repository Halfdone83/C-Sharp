
int annualTax = int.Parse(Console.ReadLine());

double shoesPrice = annualTax * 0.60;
double clothesPrice = shoesPrice * 0.80;
double ballPrice = clothesPrice / 4;
double accessoariesPrice = ballPrice / 5;


double expenses = annualTax + shoesPrice + clothesPrice + ballPrice + accessoariesPrice;

Console.WriteLine(expenses);