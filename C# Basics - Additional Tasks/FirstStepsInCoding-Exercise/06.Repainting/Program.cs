
using System.Transactions;

double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5;

int nylonNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int thinnerNeeded = int.Parse(Console.ReadLine());
int workHours = int.Parse(Console.ReadLine());

double totalNylonPrice = (nylonNeeded + 2) * nylonPrice;
double totalPaintPrice = (paintNeeded + (paintNeeded * 0.10)) * paintPrice;
double totalThinnerPrice = thinnerPrice * thinnerNeeded;
double bagsPrice = 0.40;

double totoalMoneyNeeded = totalNylonPrice + totalPaintPrice + totalThinnerPrice + bagsPrice;

double workersMoneyPerHour = totoalMoneyNeeded * 0.30;
double totoalWrokersMoney = workersMoneyPerHour * workHours;

Console.WriteLine(totoalMoneyNeeded + totoalWrokersMoney);




