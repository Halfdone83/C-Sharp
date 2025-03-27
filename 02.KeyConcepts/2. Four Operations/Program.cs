double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double Addition = firstNumber + secondNumber;
double Substraction = firstNumber - secondNumber;
double Multiplication = firstNumber * secondNumber;
double Division = firstNumber / secondNumber;


Console.WriteLine($"{firstNumber:f2} + {secondNumber:f2} = {Addition:f2}");
Console.WriteLine($"{firstNumber:f2} - {secondNumber:f2} = {Substraction:f2}");
Console.WriteLine($"{firstNumber:f2} * {secondNumber:f2} = {Multiplication:f2}");
Console.WriteLine($"{firstNumber:f2} / {secondNumber:f2} = {Division:f2}");
