using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        //The following is the exercise he gave us in the video:

        // Create a base class Car with two properties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired!" onto the console 
        /* Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
           called Model. Also a private member called brand. Brand should be different in each of the two classes.*/
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.

        static void Main(string[] args)
        {
            var cars = new List<car>
            {
                new Audi("A4", 200, "Blue"),
                new BMW("M3", 200, "Blue")
            };//This displays 1 form of polymorphism, YOU CAN USE CLASSES WITH LISTS!

            foreach(var car in cars)
            {
                //The virtual method is invoked via sub-classes
                car.Repair();
            }

            car m5 = new BMW("M5", 200, "Green");//car class (base class)
            BMW m7 = new BMW("M7", 450, "Gray");//BMW class
            m5.ShowDetails();//Output is of car ShowDetail() method
            m7.ShowDetails();//Output is of BMW ShowDetail() method

            car carB = (car)m7;//Casting a class, subclass->baseclass
            carB.ShowDetails();//Car B is a base class, it's no longer a BMW. 

            M3 myM3 = new M3("M3 Super", 350, "Silver");
            myM3.Repair();

            myM3.SetCarIdInfo(1234, "Sean Mongru");//Displaying ' Has A ' Relationships
            myM3.GetCarIdInfo();

            Console.ReadKey();

        }
    }
}
