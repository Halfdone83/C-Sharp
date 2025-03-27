int number = int.Parse(Console.ReadLine());

string[] DayOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if  (number >= 1 && number <= 7)
{
    Console.WriteLine(DayOfWeek[number - 1]);

}
else
    Console.WriteLine("Invalid day!");