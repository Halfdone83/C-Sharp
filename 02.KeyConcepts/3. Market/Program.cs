double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQantity = double.Parse(Console.ReadLine());



double tomatoCost = tomatoPrice * tomatoQuantity;
double cucumberCost = cucumberPrice * cucumberQantity;

double totalCost = tomatoCost + cucumberCost;

Console.WriteLine($"{totalCost:f2}");
