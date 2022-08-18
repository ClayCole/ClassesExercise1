using System.Collections.Generic;
using System;
using ClassesExercises;

////Create a new instance of the Car class
//Make sure you are inside of the Main() method’s scope
//Set all of the object’s properties with a value
//Print the values of each property to the Console

internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();  // Car(); - this is called Constructor - special member method. Helps us create a new instance of Car class
        myCar.Make = "Buick";
        myCar.Model = "Regal";
        myCar.Year = 2012;
        // ^^ this above is DOT notation way 



        // Now say you wanted to do another car, you can do this and make it shorter as its in the scope of the main method:
        var ford = new Car()   // Ford is the Object 
        {
            Make = "ford",  // Note that you will use Commons , instead of ;
            Model = "F150",  
            Year = 2020,

        }; // Note the simicolon goes at the end here

        // ^^ this way is Object intializer way 


        var chevy = new Car("chevy", "Impala", 2008);

        // ^^^ another way to write it

        var carList = new List<Car>() { myCar, ford, chevy};  // List<Car>() --  is the Constructor

        //Console.WriteLine(carList.Capacity);

        foreach (var vehicle in carList)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }

    }
}