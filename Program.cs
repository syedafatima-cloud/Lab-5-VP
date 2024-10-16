using System;

public enum Department
{
    ComputerScience,
    ElectricalEngineering,
    MechanicalEngineering,
    CivilEngineering
}

public class Person
{
    private string name;

    public Person()
    {
        name = null;
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
    private Department program;

    public Student() : base()
    {
        regNo = null;
        age = 0;
        program = Department.ComputerScience; 
    }

    public Student(string name, string regNo, int age, Department program) : base(name)
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

    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}

class Program
{
    static void Main()
    {
    
        Person person = new Person("Syeda Fatima");
        Console.WriteLine("Person's name: " + person.Name);

        Student student = new Student("Maham Kamran", "12345", 20, Department.ComputerScience);
        Console.WriteLine("Student's name: " + student.Name);
        Console.WriteLine("Student's registration number: " + student.RegNo);
        Console.WriteLine("Student's age: " + student.Age);
        Console.WriteLine("Student's program: " + student.Program);
    }
}