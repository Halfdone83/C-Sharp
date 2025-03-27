
double depositAmount = double.Parse(Console.ReadLine());

int term = int.Parse(Console.ReadLine());  

double interest = double.Parse(Console.ReadLine());

double totalAmount = depositAmount + term * ((depositAmount * interest/100) / 12);

Console.WriteLine(totalAmount);