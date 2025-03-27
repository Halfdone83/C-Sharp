string text = Console.ReadLine();

Dictionary<char, int> charCount = new Dictionary<char, int>();


foreach (char letter in text)
{

    if (letter != ' ')
    {

        if (charCount.ContainsKey(letter))
        {

            charCount[letter]++;
        }
        else
        {
            charCount.Add(letter, 1);

        }
    }
}

foreach (var kvp in charCount)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

}

