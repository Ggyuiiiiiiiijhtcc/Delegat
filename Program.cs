using System;

struct Student
{
    public string Name;
    public int Age;
    public double AverageScore;
}

class Program
{
    delegate double RateCriteria(Student student);

    static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student() { Name = "Иванов", Age = 20, AverageScore = 4.2 },
            new Student() { Name = "Петров", Age = 21, AverageScore = 4.8 },
            new Student() { Name = "Сидоров", Age = 19, AverageScore = 3.5 },
            new Student() { Name = "Козлов", Age = 22, AverageScore = 4.1 },
            new Student() { Name = "Смирнов", Age = 20, AverageScore = 3.9 },
            new Student() { Name = "Иванова", Age = 19, AverageScore = 4.7 },
            new Student() { Name = "Петрова", Age = 21, AverageScore = 3.8 },
            new Student() { Name = "Сидорова", Age = 20, AverageScore = 4.0 },
            new Student() { Name = "Козлова", Age = 22, AverageScore = 3.2 },
            new Student() { Name = "Смирнова", Age = 21, AverageScore = 4.5 },
        };

        RateCriteria rateCriteria = (Student student) => student.AverageScore;

        Array.Sort(students, (s1, s2) => rateCriteria(s2).CompareTo(rateCriteria(s1)));
        
        foreach (var student in students)
        {
            Console.WriteLine("{0,-10}{1,-5}{2}", student.Name, student.Age, student.AverageScore);
        }
    }
}
