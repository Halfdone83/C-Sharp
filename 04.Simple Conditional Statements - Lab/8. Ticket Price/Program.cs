string ticketType = Console.ReadLine();

double ticketPrice = 0;

if (ticketType == "student")
{
    ticketPrice = 1;
    Console.WriteLine($"${ticketPrice:f2}");
}
else if (ticketType == "regular")
{
    ticketPrice = 1.60;
    Console.WriteLine($"${ticketPrice:f2}");
}

else
{
    Console.WriteLine("Invalid ticket type!");

}