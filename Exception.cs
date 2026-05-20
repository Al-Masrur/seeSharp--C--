using System;

public class MyClass
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter first num: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter n2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b > 1000)
            {
                throw new ArgumentException("num2 cant be greater than 1000");  
            }
        
            Console.WriteLine($"Result: {a / b}");
        }
        catch (ArgumentException e) 
        {
            // Specific exception first
            Console.WriteLine($"Argument Error: {e.Message}");
        }
        catch (Exception e) 
        {
            // General catch-all last
            Console.WriteLine($"General Error: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Program ended.........");
        }
    }
}