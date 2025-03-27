
string input = Console.ReadLine();

Console.WriteLine(VowelsInText(input));


static int VowelsInText(string input)
{
    int vowelCount = 0;

    foreach (char character in input.ToLower())
    {

        if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
        {
            vowelCount++;
        }

    }
    return vowelCount;
}
