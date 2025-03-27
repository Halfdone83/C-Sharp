using System;

int number = int.Parse(Console.ReadLine());


int[] firstArray = new int[number];
int[] secondArray = new int[number];


for  (int i = 0; i < number; i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    int numberOne = input[0];
    int numberTwo = input[1];



    if (i % 2 ==0)
    {
        firstArray[i] = numberOne;
        secondArray[i] = numberTwo;
        
    }
    else
    {
        firstArray[i] = numberTwo;
        secondArray[i] = numberOne;
    }
    
}
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));