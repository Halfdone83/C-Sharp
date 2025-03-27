string wordToRemove = Console.ReadLine();

string sentence  = Console.ReadLine();


while (sentence.Contains(wordToRemove))
    {

    sentence = sentence.Replace(wordToRemove, "");

    }

Console.WriteLine(sentence);