using Microsoft.VisualBasic;

List<string>words = Console.ReadLine().Split(" ").ToList();


Dictionary<string, int>oddNumberWords = new Dictionary<string, int>();


foreach (string word in words)
{
    string lowercaseWord = word.ToLower();

    if (oddNumberWords.ContainsKey(lowercaseWord))
    {

        oddNumberWords[lowercaseWord]++;
    }
    else
    {
        oddNumberWords.Add(lowercaseWord, 1);
    }

}

foreach (var kvp in oddNumberWords.Keys)
{
    int oddWordsCount = oddNumberWords[kvp];
    if (oddWordsCount % 2 !=0)
    {

        Console.Write(kvp + " ");
    }


}
