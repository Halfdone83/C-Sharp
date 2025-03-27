using System.Security.Cryptography;

List<int> numbers= Console.ReadLine().Split(" ").Select(int.Parse).ToList();

SortedDictionary<int, int>sortedNumbers= new SortedDictionary<int, int>();


foreach (int number in numbers)
{
    if (sortedNumbers.ContainsKey(number))
    {
        sortedNumbers[number]++;
    }
    else
    {
        sortedNumbers.Add(number, 1);
    }
}

foreach (var kvp in sortedNumbers)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

}