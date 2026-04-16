using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    // Constructor
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input
        Console.Write("Enter student's name:");
        string name = Console.ReadLine();

        Console.Write("\nEnter student's age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nEnter student's grade:\n");
        string grade = Console.ReadLine();

        // Create object
        Student student = new Student(name, age, grade);

        // Output
        Console.WriteLine($"Student Name: {student.Name}");
        Console.WriteLine($"Student Age: {student.Age}");
        Console.WriteLine($"Student Grade: {student.Grade}");
    }
}