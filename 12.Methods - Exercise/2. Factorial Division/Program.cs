int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());


int firtsFactoriel = FindFactoriel(number1);
int secondFactoriel = FindFactoriel(number2);


Console.WriteLine(firtsFactoriel / secondFactoriel);


static int FindFactoriel(int number)
{

    int factoriel = 1;

    for (int i = 1; i <= number; i++)

    {
        factoriel *= i;



    }
    return factoriel;
}