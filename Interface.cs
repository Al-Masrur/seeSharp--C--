public interface Vehicle
{
    void EngineType();
    void Wheels();

}

public class Car : Vehicle
{
    public string name;
    public string engine;
    public int wheel;

    public Car(string name, string engine,int wheel)
    {
        this.name = name;
        this.engine = engine;
        this.wheel = wheel;
    }
    public void EngineType()
    {
        Console.WriteLine($"Name: {name}, Engine: {engine}");
    }
    public void Wheels()
    {
        Console.WriteLine($"Wheels: {wheel}");
        
    }
}

public class Interface
{
    static void Main(String[] args)
    {
        Car toyota = new Car("Crown","Hybrid",4);
        toyota.EngineType();
        toyota.Wheels();
    }
    
}
    
