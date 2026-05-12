using System.Net.Mail;

void greetings() //created a method named greetings
{
    Console.WriteLine("This msg inside a method......");
}
greetings(); // calling the 'greetings' method


//c# build-in methods
string name = "   mAsrUR"  ;

string upperName = name.ToUpper();
Console.WriteLine(upperName);  //MASRUR

string lowerName = name.ToLower();
Console.WriteLine(lowerName);  //masrur


string trimstart = name.TrimStart();
Console.WriteLine(trimstart);  //remove leading whitespace

string trimEnd = name.TrimEnd();
Console.WriteLine(trimEnd);   //remove tailing whitespaces

string message = "never gonna give you up, never gonna let you down";
Console.WriteLine(message.Contains("give"));
Console.WriteLine(message.Contains("take"));

Console.WriteLine(message.StartsWith("Hello"));
Console.WriteLine(message.EndsWith("down"));

string msg1 = message.Substring(25);
Console.WriteLine(msg1);

string text = "I love coding";
string txt1 = text.Replace("love","hate");
Console.WriteLine(txt1);


string Badtext = "I have a stupid friend who is very dumb and bolod";
string[]bad = {"stupid","dumb","bolod"};
Console.WriteLine($"Main text: {Badtext}");

string censored = Badtext;

foreach(string word in bad)
{
    string replacetext = new string('*',word.Length); //Replace the bad word with *
    censored = censored.Replace(word,replacetext);
}
Console.WriteLine($"censored: {censored}");


string[] names = { "Rahim", "Karim", "Jabbar" };
int[] marks = { 85, 92, 78 };

Console.WriteLine("Name       Marks");
Console.WriteLine("─────────────────");

for (int i = 0; i < names.Length; i++)
{
    // -10 মানে left align, 10 characters wide
    // 5 মানে right align, 5 characters wide
    Console.WriteLine($"{names[i],-10} {marks[i],0}");
}