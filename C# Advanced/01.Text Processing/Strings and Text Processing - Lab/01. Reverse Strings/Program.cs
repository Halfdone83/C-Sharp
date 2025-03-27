
string input = Console.ReadLine();



while (input != "end")
{
    string reverseWord = new string (input.Reverse().ToArray());


    Console.WriteLine($"{input} = {reverseWord}");

    input = Console.ReadLine();

    
}

