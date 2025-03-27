int productNumbers = int.Parse(Console.ReadLine());

List <string> products = new List<string>();


for  (int i = 0;  i < productNumbers; i++)
{
    string product = Console.ReadLine();
    products.Add(product);
}


products.Sort();

int counter = 1;
foreach (string product in products)
{

    Console.WriteLine($"{counter}.{product}");
    counter++;
}