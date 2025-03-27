using System.Linq.Expressions;

string[] input = Console.ReadLine().Split();


int sum  = 0;


foreach (string element in input)

    try    
    {
        int currentNum = int.Parse(element);
        sum += currentNum;
        
    }
    catch (FormatException fEx)
    {

    Console.WriteLine($"The element '{element}' is in wrong format!");

    }
    catch (OverflowException oEx)
    {

    Console.WriteLine($"The element '{element}' is out of range!");

    }
    finally
    {

        Console.WriteLine($"Element '{element}' processed - current sum: {sum}");

    }
    
Console.WriteLine($"The total sum of all integers is: {sum}");

   

