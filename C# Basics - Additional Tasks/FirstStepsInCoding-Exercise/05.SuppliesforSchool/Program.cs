
double pensPrice = 5.80;
double markersPrice = 7.20;
double detergentPrice = 1.20; 

int pensPackages = int.Parse(Console.ReadLine());
int markersPackages = int.Parse(Console.ReadLine());
int detergentAmount = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double totalPensPrice = pensPrice * pensPackages;
double totalMarkersPrice = markersPrice * markersPackages;
double totalDetergentPrice = detergentPrice * detergentAmount;
double totalMoneyNeeded = (totalPensPrice + totalMarkersPrice + totalDetergentPrice);
double finalMoney = totalMoneyNeeded - (totalMoneyNeeded * discount / 100);


Console.WriteLine(finalMoney);

