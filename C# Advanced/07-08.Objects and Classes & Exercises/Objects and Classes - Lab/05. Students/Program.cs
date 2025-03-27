using System.Collections.Generic;
using System.Diagnostics;

int studentsNumber = int.Parse(Console.ReadLine());

List<Student> studentsList = new List<Student>();

for (int i = 0; i < studentsNumber; i++)
{
    string[] studentInfo = Console.ReadLine().Split();
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    double grade = double.Parse(studentInfo[2]);

    Student currentStudent = new Student(firstName, lastName, grade);
    studentsList.Add(currentStudent);
}

foreach (Student student in studentsList.OrderByDescending(s =>s.Grade))
{
    Console.WriteLine($"{student.FirstName} {student.LastName }: {student.Grade:F2}");
}

class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }
}
