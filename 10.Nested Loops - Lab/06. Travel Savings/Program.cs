string destination = Console.ReadLine();
double budget = double.Parse(Console.ReadLine());

double collectedMoney = 0;

double money = 0;

while (destination != "End")
{
    while (collectedMoney <= budget)
    {

        money = double.Parse(Console.ReadLine());

        collectedMoney += money;

        Console.WriteLine($"Collected: {collectedMoney:F2}");

        if (collectedMoney >= budget)
        {
            Console.WriteLine($"Going to {destination}!");

            collectedMoney = 0;

            destination = Console.ReadLine();

            if (destination == "End")
            {
                break; 
            }


            budget = double.Parse(Console.ReadLine());
        }

    }
    

}