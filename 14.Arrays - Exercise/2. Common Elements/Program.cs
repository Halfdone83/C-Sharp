

int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


foreach (int i in arrayOne)
{
    if (arrayTwo.Contains(i))
    {
        Console.Write(i + " ");
    }


}
