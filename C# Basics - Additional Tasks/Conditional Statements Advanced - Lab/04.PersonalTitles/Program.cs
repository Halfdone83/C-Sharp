

double age = double.Parse(Console.ReadLine());
string sex  = Console.ReadLine();

if (sex == "m")
{
    if (age < 16)
    {
        Console.WriteLine("Master");
    }
    else
    {
        Console.WriteLine("Mr.");
    }
}
else
{
    if (age < 16)
    {
        Console.WriteLine("Miss");
    }
    else
    {
        Console.WriteLine("Ms.");
    }
}