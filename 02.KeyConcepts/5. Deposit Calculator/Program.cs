double depositAmount = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualRate = double.Parse(Console.ReadLine());



double amount = depositAmount + depositTerm * (depositAmount * annualRate / 100) / 12;

Console.WriteLine(amount);