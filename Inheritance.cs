using System.Globalization;
using System.Security.Cryptography;

public class Person
{
    public string name;
    public int id;
    public int age;

    public Person(string name, int id, int age)
    {
        this.name = name;
        this.id = id;
        this.age = age;
    }

    public void printInfo()
    {
        Console.WriteLine($"Initial info:\nName: {name}, age:{age}, id: {id}\n");
    }
}

class Student : Person
{
    public string gender;
    public Student(string gender,int id,int age, string name) : base(name,id,age)
    {
        this.gender = gender;
    }

    public void printInfo()
    {
        Console.WriteLine($"All info:\nname: {name}, age: {age}, id: {id}, gender: {gender}");
        
    }
}

class Inheritance
{
    static void Main(String[] args)
    {
        Person p1 = new Person("Masrur",147,22);
        p1.printInfo();
        Student s1 = new Student("Male",147,22,"Masrur");
        s1.printInfo();

        
    }
}