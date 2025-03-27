string product = Console.ReadLine();

int quantity = int.Parse(Console.ReadLine());


Console.WriteLine(TotalPrice(product, quantity).ToString("F2"));

static double TotalPrice(string product, int quantity)
{
    double price = 0;

    switch (product)
    {
        case "coffee":
            price = 1.50 * quantity;
            break;

        case "water":
            price = 1.00 * quantity;
            break;

        case "coke":
            price = 1.40 * quantity;
            break;

        case "snacks":
            price = 2.00 * quantity;
            break;



    }
    return price;

}