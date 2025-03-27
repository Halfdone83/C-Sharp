int size = int.Parse(Console.ReadLine());


TraingleOfStars(size);


static void TraingleOfStars(int size)
{

    for (int starr = 1; starr <= size; starr++)
    {

        for (int starw = 1; starw <= starr; starw++)

        {
            Console.Write(starw + " ");

        }

        Console.WriteLine();

    }


    for (int starr = size - 1; starr >= 1; starr--)
    {

        for (int starw = 1; starw <= starr; starw++)

        {
            Console.Write(starw + " ");

        }

        Console.WriteLine();

    }
}