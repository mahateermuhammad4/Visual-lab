using System;

public class Person
{
    private string name;

    public Person()
    {
        name = string.Empty;
    }

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    private string regNo;
    private int age;
    private string program;

    public Student() : base()
    {
        regNo = string.Empty;
        age = 0;
        program = "Science";  
    }

    public Student(string name, string regNo, int age, string program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Program
    {
        get { return program; }
        set { program = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Mahateer";
        student1.RegNo = "233539";
        student1.Age = 20;
        student1.Program = "CS";  

        Student student2 = new Student("Mahad", "233523", 20, "CS");

        Console.WriteLine("Details of Student 1:");
        DisplayStudentInfo(student1);

        Console.WriteLine("\nDetails of Student 2:");
        DisplayStudentInfo(student2);
    }

    public static void DisplayStudentInfo(Student student)
    {
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Reg No: {student.RegNo}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Program: {student.Program}");
    }
}
