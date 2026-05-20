using System.Globalization;
using System.Security.Cryptography;

public class Person
{
    public string name;
    public int id;

    public Person(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public void printInfo()
    {
        Console.WriteLine($"Initial info:\nName: {name}, id: {id}\n");
    }
}

class Student : Person
{
    public string gender;
    public Student(string gender,int id, string name) : base(name,id)
    {
        this.gender = gender;
    }
    public new void printInfo()
    {
        Console.WriteLine($"All info:\nname: {name}, id: {id}, gender: {gender}");
        
    }
}

class Inheritance
{
    static void Main(String[] args)
    {
        Console.WriteLine($"Enter Your Name: ");
        string name = Console.ReadLine() ?? "";

        Console.WriteLine($"Enter Your ID: ");
        int id =Convert.ToInt32(Console.ReadLine());

        Person p1 = new Person(name,id);
        p1.printInfo();

        Console.WriteLine($"Enter Your Gender: ");
        string gender = Console.ReadLine() ?? "";

        Student s1 = new Student(gender,id,name);
        s1.printInfo();

        
    }
}