string[] wordsToRemove = Console.ReadLine().Split(", ");

string text = Console.ReadLine();


foreach (string word in wordsToRemove)
{

    while (text.Contains(word))
    {

        string wordToReplaceWith = new string('*', word.Length) ;

       
        text = text.Replace(word, wordToReplaceWith);

    }

}

Console.WriteLine(text);


