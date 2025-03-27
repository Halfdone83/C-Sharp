double grade = double.Parse(Console.ReadLine());

GradeScore(grade);



static void GradeScore(double g)
{
    if (g >= 2.00 && g <= 2.99)
    {
        Console.WriteLine("Fail");
    }

    else if (g >= 3.00 && g <= 3.49)
    {
        Console.WriteLine("Average");
    }
    else if(g >= 3.50 && g <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if (g >= 4.50 && g <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else
    {
        Console.WriteLine("Excellent");
    }
}