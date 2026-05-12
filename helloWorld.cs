using System;
using System.Runtime.CompilerServices;

/*
In this file, we will learn how to show ooutput in C#
*/

Console.Write("This line is first "); //Console.Write = prints and stays on the same line 
Console.Write("This line is second"); 

Console.WriteLine(); //this prints an empty line

Console.WriteLine("Welcome to"); //Console.WriteLine = prints and goes to new line
Console.WriteLine("C# language"); 



//Now, lets learn to take input and print them

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine(); //Console.ReadLine = takes input from user
Console.WriteLine("Hello " + name); //prints the string "Hello " with  name 

//there are other ways to print string and variable inside the same quotation
string greet = "Good Morning";
Console.WriteLine($"{greet}, {name}"); //using string interpolation $

// if you want to print quotes, backslash, dollar sign, file path
Console.WriteLine(@" "" This is a quote"", this is a file path - C:\Users\{userName}\Documents "); //using verbatim string literal @