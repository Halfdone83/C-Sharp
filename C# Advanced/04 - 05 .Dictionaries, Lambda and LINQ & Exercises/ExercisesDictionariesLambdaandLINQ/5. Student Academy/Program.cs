int counter = int.Parse(Console.ReadLine());


Dictionary<string, List<double>>Grades = new Dictionary<string, List<double>>();


for (int i = 0; i < counter; i++)

{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());


    if (Grades.ContainsKey(name))
    {

        Grades[name].Add(grade);

    }
    else
    {

        Grades.Add(name, new List<double> { grade }); ;
    }

}

foreach (var kvp  in Grades)
{
    double average = kvp.Value.Average();

    if (average >= 4.50)
    {
        Console.WriteLine($"{kvp.Key} -> {average:F2}");
    }
}