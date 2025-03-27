string type = Console.ReadLine();


PrintStringType(type);



static void PrintStringType(string type)
{
    if (type == "int")
    {
        int valueOne = int.Parse(Console.ReadLine());
        int valueTwo = int.Parse(Console.ReadLine());

        if (valueOne >= valueTwo)
        {
            Console.WriteLine(valueOne);
        }
        else
        {
            Console.WriteLine(valueTwo);
        }

    }
    else if (type == "char")
    {
        char valueOne = char.Parse(Console.ReadLine());
        char valueTwo = char.Parse(Console.ReadLine());

        if (valueOne >= valueTwo)
        {
            Console.WriteLine(valueOne);
        }
        else
        {
            Console.WriteLine(valueTwo);
        }
    }

    else
    {

        string firstText = Console.ReadLine();
        string secondText = Console.ReadLine();

        if (String.Compare(firstText, secondText) >= 0)
        {
            Console.WriteLine(firstText);
        }
        else
        {
            //String.Compare(firstText, secondText) < 0
            Console.WriteLine(secondText);
        }


    }
}