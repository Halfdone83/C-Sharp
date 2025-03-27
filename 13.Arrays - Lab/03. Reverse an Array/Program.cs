int number = int.Parse(Console.ReadLine());


int[] numbers = new int[number];



for (int n = 1; n <= number; n++)
{
    
    int value = int.Parse(Console.ReadLine());

    numbers[n - 1] = value;

 }

for (int i = numbers.Length - 1; i >=0;  i--)
{
    Console.Write(numbers[i] + " ");

}
