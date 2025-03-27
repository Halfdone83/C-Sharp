int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int controlNumber = int.Parse(Console.ReadLine());

for  (int i = 0; i < numbers.Length - 1; i++)
{
    int currentNum = numbers[i];

        for (int j = i + 1; j < numbers.Length; j++)
    {

        int nextNum = numbers[j];

        if (currentNum + nextNum == controlNumber)
        {
            Console.WriteLine(currentNum + " "  + nextNum);
        }

    }


}