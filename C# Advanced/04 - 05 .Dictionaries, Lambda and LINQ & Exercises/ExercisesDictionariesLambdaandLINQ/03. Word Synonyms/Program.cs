using System.Collections.Generic;

int counter = int.Parse(Console.ReadLine());


Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

for (int i = 0; i < counter; i++)
{

    string word = Console.ReadLine();
    string synonim = Console.ReadLine();


    if (dictionary.ContainsKey(word))
    {


        dictionary[word].Add(synonim);
    }
    else
    {
        dictionary.Add(word, new List<string>() { synonim });
    }

}
foreach (var kvp in dictionary)
{

    Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
}