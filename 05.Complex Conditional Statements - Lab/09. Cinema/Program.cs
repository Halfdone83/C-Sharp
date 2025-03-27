string movie = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());


double premierePrice = 12;
double normalPrice = 7.50;
double discountPrice = 5;

int totalSeats = rows * seats;

double totalPrice = 0;

switch (movie)
{
    case "Premiere":

        totalPrice = totalSeats * premierePrice;
        Console.WriteLine($"{totalPrice:f2}");
        break;

    case "Normal":
        totalPrice = totalSeats * normalPrice;
        Console.WriteLine($"{totalPrice:f2}");
        break;

    case "Discount":
        totalPrice = totalSeats * discountPrice;
        Console.WriteLine($"{totalPrice:f2}");
        break;
}
