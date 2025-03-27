int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegeterainMenus = int.Parse(Console.ReadLine());

double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegeterainMenuPrice = 8.15;
double deliveryPrice = 2.50;

double chickenMenusPrice = chickenMenus * chickenMenuPrice;
double fishMenusPrice = fishMenus * fishMenuPrice;
double vegeterainMenusPrice = vegeterainMenus * vegeterainMenuPrice;


double totalMenusPrice = chickenMenusPrice + fishMenusPrice + vegeterainMenusPrice;

double desertPrice = totalMenusPrice * 0.20;

double totalBill = totalMenusPrice + desertPrice + deliveryPrice;

Console.WriteLine($"{totalBill}");