using System.ComponentModel.Design;

string product = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;

if (product == "Banana")
{
    if (day == "Weekday")
    {
        price = 2.50;
    }
    else
    {
        price = 2.70;
    }

    Console.WriteLine($"{price:f2}");

}
else if (product == "Apple")
{
    if (day == "Weekday")
    {
        price = 1.30;
    }
    else
    {
        price = 1.60;
    }

    Console.WriteLine($"{price:f2}");
}

else
{
    if (day == "Weekday")
    {
        price = 2.20;
    }
    else
    {
        price = 3.00;
    }

    Console.WriteLine($"{price:f2}");

}