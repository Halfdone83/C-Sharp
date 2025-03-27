string input = Console.ReadLine();


string digits = string.Empty;
string letters = string.Empty;
string otherChars  = string.Empty;

foreach (char symbol in input)
{

    if (Char.IsDigit(symbol))
    {
        digits += symbol;
    }
    else if (Char.IsLetter(symbol))
    {

    letters += symbol;
    
    }
    else
    {
        otherChars += symbol;
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(otherChars);