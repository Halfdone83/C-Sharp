int pagesLeft = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int readingTime = pagesLeft / pagesPerHour;

int hoursPerDay = readingTime / days;



Console.WriteLine(hoursPerDay);
