using System.Runtime.CompilerServices;

class Person
{
    public string name ="";
    public int age;

    public Person()
    {
        Console.WriteLine("This is default Constructor");
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Test
{
    static void Main(String[] args)
    {
        Person p1 = new Person("Masrur",22);
        Person p2 = new Person("Abdullah",23);
        Person p3 = new Person(); //this call the default constructor with no parameter
      p1.DisplayInfo();
      p2.DisplayInfo();

    }
}