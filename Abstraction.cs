public abstract class Animal
{
    public abstract void Sound();
}

public class Cat : Animal
{

    public override void Sound()
    {
        Console.WriteLine($"cat sound: meow");
        
    }
    public void haveLegs()
    {
        Console.WriteLine($"true");
        
    }
}

public class Abstraction
{
    static void Main(string[]args)
    {
        Cat cat = new Cat();
        cat.haveLegs();
        cat.Sound();

    }
}