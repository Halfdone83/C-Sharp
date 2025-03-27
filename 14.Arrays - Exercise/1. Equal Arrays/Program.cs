
int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isTrue = true;

for (int i = 0; i < arrayOne.Length; i++)
{
    if (arrayOne[i] != arrayTwo[i])
    { 
    isTrue = false;
    break;
}

}

if (isTrue)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}