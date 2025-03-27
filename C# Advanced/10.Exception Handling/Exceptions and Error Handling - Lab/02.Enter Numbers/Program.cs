int start = 1;
int end = 100;

List<int> numbers = new List<int>();

while (numbers.Count < 10)
{
    try 
    {
    
        int number = ReadNumber(start, end);
        numbers.Add(number);
        start = number;

    }

    catch (FormatException fEx)
    { 
    
        Console.WriteLine(fEx.Message);
    
    }

    catch (ArgumentException aEx)
    {

        Console.WriteLine(aEx.Message);

    }

}

Console.WriteLine(string.Join(", ", numbers.ToArray()));



static int ReadNumber(int start, int end)
{

    string input = Console.ReadLine();

    try
    {
        int number = int.Parse(input);

        if (number > start && number < end)
        {

            return number;

        }
        else
        {
            throw new ArgumentException($"Your number is not in range {start} - 100!");
        }

    }
    catch (FormatException fEx)
    {


        throw new FormatException("Invalid Number!");


    }



}