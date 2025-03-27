using System;

string input = Console.ReadLine();

double balance = 0;

double amount = 0;


while (input != "End")
{
    amount = double.Parse(input);

    if (amount > 0)
    {

    balance += amount;

        Console.WriteLine($"Increase: {amount:F2}");

        
    }
    else if (amount < 0)
    {
        balance += amount;

        Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
       
    }

    input = Console.ReadLine();

} 



Console.WriteLine($"Balance: {balance:F2}");