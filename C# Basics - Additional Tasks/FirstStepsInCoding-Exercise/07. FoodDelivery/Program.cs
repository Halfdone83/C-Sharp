
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegeterianMenuPrice = 8.15;
double deliveryPrice = 2.50;

int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegeterianMenus = int.Parse(Console.ReadLine());

double chickenPrice = chickenMenus * chickenMenuPrice;
double fishPrice = fishMenuPrice * fishMenus;
double vegeterianPrice = vegeterianMenus * vegeterianMenuPrice;

double totalFoodPrice = chickenPrice + fishPrice + vegeterianPrice;

double desertPrice = totalFoodPrice * 0.20;

double amountToPay = totalFoodPrice + desertPrice + deliveryPrice;

Console.WriteLine(amountToPay);


