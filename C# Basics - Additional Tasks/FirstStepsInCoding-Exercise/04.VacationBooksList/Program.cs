
int bookPages = int.Parse(Console.ReadLine());

int pagesPerHour = int.Parse(Console.ReadLine());

int days = int.Parse(Console.ReadLine());

int totalHours = bookPages / pagesPerHour;

int hoursPerDay = totalHours / days;

Console.WriteLine(hoursPerDay);



