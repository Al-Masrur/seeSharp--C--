using System;
using System.Collections.Generic;

namespace ContactBook
{
    class Program 
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            bool running = true;

            Console.WriteLine("------ Contact Book ------");

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Search Contact");
                Console.WriteLine("3. Display All");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Name: ");
                        string name = Console.ReadLine() ?? "";
                        
                        Console.WriteLine("Enter Number: ");
                        string number = Console.ReadLine() ?? "";

                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            if (!contacts.ContainsKey(name))
                            {
                                contacts.Add(name, number);
                                Console.WriteLine("-------- Contact added successfully --------");
                            }
                            else
                            {
                                Console.WriteLine("-------- Name already exists --------");
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Search Name: ");
                        string search = Console.ReadLine() ?? "";
                        
                        if (contacts.TryGetValue(search, out string found))
                        {
                            Console.WriteLine($"Phone: {found}");
                        }
                        else
                        {
                            Console.WriteLine("Number not found.......");
                        }
                        break;

                    case "3":
                        Console.WriteLine("-------- Contact List --------");
                        if (contacts.Count == 0)
                        {
                            Console.WriteLine("The list is currently empty.");
                        }
                        else
                        {
                            foreach (var entry in contacts)
                            {
                                Console.WriteLine($"Name: {entry.Key}, Number: {entry.Value}");
                            }
                        }
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}