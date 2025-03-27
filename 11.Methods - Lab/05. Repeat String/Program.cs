string text = Console.ReadLine();

int repeats = int.Parse(Console.ReadLine());

RepeatString(repeats, text);

static void RepeatString(int repeats, string text)
{
    for (int count = 1; count <= repeats; count++)

    {

        Console.Write(text);
    }
}