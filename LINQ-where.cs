/*public class Test
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>{1,3,5,7,9,2};
        var even = number.Where(num=> num%2==0);

        Console.WriteLine($"Total even numbers: {even.Count()}");

        if (even.Any())
        {
             Console.Write($"Even numbers:");
        
        foreach(var n in even)
        {
            Console.Write($" {n}");
            
        }
        }
        else
        {
            Console.WriteLine($"There are no even numbers.....");
            
        }

       
    }
}

*/

public class LINQWhere
{
    static void Main(String[] args)
    {
        // List<string> word = new List<string>{"Apple","mango","lichi","banana","kathal","kiwi","pepe"};
        List<string> item = new List<string>();

        Console.WriteLine($"how many fruit will you enter?");
        int numofitem = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter fruit names: ");
        for(int i = 0; i<numofitem; i++)
        {
            string name = Console.ReadLine() ?? "";
            item.Add(name);
        }

         var longword = item.Where(size=>size.Length>4);
        Console.WriteLine($"\nLong fruit name: {longword.Count()}");

        Console.Write($"Fruits with more than 4 characters: ");
        foreach(var l in longword)
        {
            Console.Write($" {l}");
            
        }
        
        // var wordLength = word.Where(size=>size.Length>4);
        // Console.WriteLine($"words: {wordLength.Count()}");

        // Console.WriteLine($"Fruits with more than 4 characters: ");
        // foreach(var w in wordLength)
        // {
        //     Console.Write($" {w}");
        // }
    }
}