double number1 = int.Parse(Console.ReadLine());
double number2 = int.Parse(Console.ReadLine());

string moperator  = Console.ReadLine();


double result = 0;

switch (moperator)
{
    case "+":
        result = number1 + number2;
        Console.WriteLine($"{number1} {moperator} {number2} = {result:f2}");
        break;

    case "-":
        result = number1 - number2;
        Console.WriteLine($"{number1} {moperator} {number2} = {result:f2}");
        break;

    case "*":
        result = number1 * number2;
        Console.WriteLine($"{number1} {moperator} {number2} = {result:f2}");
        break;

    case "/":
        result = number1 / number2;
        Console.WriteLine($"{number1} {moperator} {number2} = {result:f2}");
        break;
}