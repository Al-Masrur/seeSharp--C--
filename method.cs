class Person
{
    public string name ="";
    public int age;

    public void SetValue(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public string DisplayInfo()
    {
        return $"Name: {name}, Age: {age}";
    }
}

class Test
{
    static void Main(String[] args)
    {
        Person p1 = new Person();
        p1.SetValue("Masrur",22);
        string person1 = p1.DisplayInfo();
        Console.WriteLine(person1);

        Person p2 = new Person();
        p2.SetValue("Abdullah",22);
        string person2 = p2.DisplayInfo();
        Console.WriteLine(person2);

    }
}