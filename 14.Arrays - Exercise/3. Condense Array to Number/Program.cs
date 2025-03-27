int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();



while (numbers.Length > 1)
{

    int[] reducedArray = new int[numbers.Length - 1];

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int currentSum = numbers[i] + numbers[i + 1];
        reducedArray[i] = currentSum;
        
    }
    numbers = reducedArray;
}
Console.WriteLine(numbers[0]);