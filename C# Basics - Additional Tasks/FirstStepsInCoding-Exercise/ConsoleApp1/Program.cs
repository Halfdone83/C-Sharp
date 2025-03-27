int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double dogCost = dogFood * 2.50;
double catCost = catFood * 4;

Console.WriteLine($"{dogCost + catCost} lv.");
