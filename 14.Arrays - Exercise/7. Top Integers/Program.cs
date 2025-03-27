int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();



for  (int i = 0; i < numbers.Length; i++)

{

    bool topInteger = true;

    int firstNum = numbers[i];

    for (int j = i + 1; j < numbers.Length; j++)
    {
        int nextNum = numbers[j];

        if (firstNum <= nextNum)
        {
           topInteger = false;
            break;
        }

    }
    if (topInteger) 
    {
        Console.Write(firstNum + " ");
    }

}