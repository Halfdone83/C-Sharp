
string password = Console.ReadLine();


if (CheckPasswordLengthSixTen(password)
    && CheckPasswordLettersAndDigits(password)
    && CheckPasswordTwoDigits(password))
{
    Console.WriteLine("Password is valid");
}

if (!CheckPasswordLengthSixTen(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!CheckPasswordLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!CheckPasswordTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}


static bool CheckPasswordLengthSixTen(string pass)
{
    if (pass.Length >= 6 && pass.Length <= 10)

        return true;
    else return false;
}


static bool CheckPasswordLettersAndDigits(string pass)
{
    for (int i = 0; i < pass.Length; i++)
    {
        char currentChar = pass[i];

        if (!char.IsLetterOrDigit(currentChar))
            return false;
    }
    return true;
}

static bool CheckPasswordTwoDigits(string pass)
{
    int counter = 0;

    for (int j = 0; j < pass.Length; j++)
    {
        char currentLetter = pass[j];

        if (char.IsDigit(currentLetter))
        {
            counter++;

            if (counter >= 2)
            {
                return true;
            }

        }
    }
    return false;

}