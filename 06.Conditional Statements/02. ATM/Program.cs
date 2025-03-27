int balance = int.Parse(Console.ReadLine());
int winthdraw  = int.Parse(Console.ReadLine());
int limit  = int.Parse(Console.ReadLine());


if  (winthdraw < balance && winthdraw < limit)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (winthdraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else
{
    Console.WriteLine("Insufficient availability.");
}