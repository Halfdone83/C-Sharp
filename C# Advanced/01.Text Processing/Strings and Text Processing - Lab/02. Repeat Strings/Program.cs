string[] strings = Console.ReadLine().Split(" ").ToArray();

foreach (string word in strings)
{

    int length = word.Length;

    for (int i = 0; i < length; i++)

    {
        Console.Write(word);

    }

}