using System;

namespace myApp
{
    //this is a class
    class Car                   
    {
        //attributes of car class
        public string color ="";         
        public string model ="";

    }

    //this is another class
    class Vehicle               
    {
        static void Main(string[] args)
        {
            Car toyota = new Car();            //obj of Car class inside Vehicle class
            toyota.color = "red";
            toyota.model = "crown";
            Console.WriteLine("Car 1:\n"+ toyota.color);    //calling car class attributes
            Console.WriteLine(toyota.model); 

Console.WriteLine("");

            Car lamborghini = new Car();            //obj of Car class inside Vehicle class
            toyota.color = "yellow";
            toyota.model = "Aventador";
            Console.WriteLine("Car 2:\n"+toyota.color);    //calling car class attributes
            Console.WriteLine(toyota.model);

        }
    }
}