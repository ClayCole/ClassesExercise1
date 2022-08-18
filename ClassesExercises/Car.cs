using System;
namespace ClassesExercises
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string makeInput, string modelInput, int year) // so when you call this in the main class you wont have define it as its already here
        {
            Make = makeInput;     // in this sitaution the Make is referring to the property and make is referring to the perameter
            Model = modelInput;
            Year = year;

        }


        //Create a Make property of type string that is public

        public string Make { get; set; } // get = read , set = write
        public string Model { get; set; }
        public int Year { get; set; }


    }
}

