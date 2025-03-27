using System.ComponentModel.Design;

string season = Console.ReadLine();
string accommodation  = Console.ReadLine();
int days = int.Parse(Console.ReadLine());


double totalPrice = 0;


if (season == "Spring")
{
    if (accommodation == "Hotel")
    {
        totalPrice = (days * 30) * 0.80;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else
    {
        totalPrice = (days * 10) * 0.80;
        Console.WriteLine($"{totalPrice:f2}");
    }


}
else if (season == "Summer")
{
    if (accommodation == "Hotel")
    {
        totalPrice = days * 50;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else
    {
        totalPrice = days * 30;
        Console.WriteLine($"{totalPrice:f2}");
    }
}
else if (season == "Autumn")
{
    if (accommodation == "Hotel")
    {
        totalPrice = (days * 20) * 0.70;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else
    {
        totalPrice = (days * 15) * 0.70;
        Console.WriteLine($"{totalPrice:f2}");
    }


}
else
{
    if (accommodation == "Hotel")
    {
        totalPrice = (days * 40) * 0.90;
        Console.WriteLine($"{totalPrice:f2}");
    }
    else
    {
        totalPrice = (days * 10) * 0.90;
        Console.WriteLine($"{totalPrice:f2}");
    }
}