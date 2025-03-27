int baseNumber = int.Parse(Console.ReadLine());
int powerNumber  = int.Parse(Console.ReadLine());   

Console.WriteLine(PowerOfNumber(baseNumber, powerNumber));

static int PowerOfNumber(int firstNum, int secondNum)
{

    int risedNumber = (int)Math.Pow(firstNum, secondNum);
    return risedNumber;

}