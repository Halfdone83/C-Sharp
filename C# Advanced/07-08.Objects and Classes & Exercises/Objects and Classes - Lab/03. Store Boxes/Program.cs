string[] input = Console.ReadLine().Split();

List<Box>boxList = new List<Box>();

while (input[0] != "end")
{
    string itemSerialNumber = input[0];
    string itemName = input[1];
    int itemQuantity = int.Parse(input[2]);
    double itemPrice = double.Parse(input[3]);

    Item currentItem = new Item(itemName, itemPrice);
    Box currentBox = new Box(itemSerialNumber, currentItem, itemQuantity);
    boxList.Add(currentBox);

    input = Console.ReadLine().Split();
}

foreach (Box box in boxList.OrderByDescending(b => b.PriceOfTheBox))
{
    Console.WriteLine($"{box.SerialNumber}");
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
    Console.WriteLine($"-- ${box.PriceOfTheBox:F2}");
}

class Item
{
    public Item(string itemName, double itemPrice)
    {
        Name = itemName;
        Price = itemPrice;
    }
    public string Name { get; set; }

    public double Price { get; set; }
}

class Box
{
    public Box(string itemSerial, Item item, int itemQuantity)
    {
        SerialNumber = itemSerial;
        Item = item;
        Quantity = itemQuantity; 
    }
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int Quantity { get; set; }

    public double PriceOfTheBox => Quantity * Item.Price;

}


