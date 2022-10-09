using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car myCar = new Car();
            Truck myTruck = new Truck();
            SUV mySUV = new SUV();

            myCar.automatic = true;
            myCar.cupHolder = true;
            myCar.wheels = 4;
            myCar.name = "My Car";
            myCar.Model = "Civic";
            myCar.Year = 2010;
            myCar.Logo = "Honda";
            myCar.Name = "Honda";

            myTruck.bedSize = 15;
            myTruck.bulletProofGlass = false;
            myTruck.wheels = 6;
            myTruck.name = "My Truck";
            myTruck.Model = "Truck";
            myTruck.Year = 2015;
            myTruck.Logo = "Horsie";
            myTruck.Name = "Ferrari";

            mySUV.cargoHoldSize = 9;
            mySUV.numSeats = 3;
            mySUV.wheels = 4;
            mySUV.name = "My SUV";
            mySUV.Model = "The New Model";
            mySUV.Year = 2001;
            mySUV.Logo = "Toyota";
            mySUV.Name = "Toyota";

            Console.WriteLine("======== Car ========");
            Console.WriteLine("Vehicle Stats:");
            Console.WriteLine($"\tHer Name: {myCar.name}, Number of Wheels: {myCar.wheels}, Model: {myCar.Model}, Year: {myCar.Year}");
            Console.WriteLine("Company Stats:");
            Console.WriteLine($"\tName: {myCar.Name}, Logo: {myCar.Logo}");
            Console.WriteLine("Car specific: ");
            Console.WriteLine($"\tIs Automatic? {myCar.automatic}, Has Cupholder? {myCar.cupHolder}");
            Console.WriteLine("====================");

            Console.WriteLine();

            Console.WriteLine("======== Truck ========");
            Console.WriteLine("Vehicle Stats:");
            Console.WriteLine($"\tHer Name: {myTruck.name}, Number of Wheels: {myTruck.wheels}, Model: {myTruck.Model}, Year: {myTruck.Year}");
            Console.WriteLine("Company Stats:");
            Console.WriteLine($"\tName: {myTruck.Name}, Logo: {myTruck.Logo}");
            Console.WriteLine("Car specific: ");
            Console.WriteLine($"\tBed Size? {myTruck.bedSize}, Has Bullet-proof Glass? {myTruck.bulletProofGlass}");
            Console.WriteLine("====================");

            Console.WriteLine();

            Console.WriteLine("======== SUV ========");
            Console.WriteLine("Vehicle Stats:");
            Console.WriteLine($"\tHer Name: {mySUV.name}, Number of Wheels: {mySUV.wheels}, Model: {mySUV.Model}, Year: {mySUV.Year}");
            Console.WriteLine("Company Stats:");
            Console.WriteLine($"\tName: {mySUV.Name}, Logo: {mySUV.Logo}");
            Console.WriteLine("Car specific: ");
            Console.WriteLine($"\tCargohold Size? {mySUV.cargoHoldSize}, Number of Seats? {mySUV.numSeats}");
            Console.WriteLine("====================");
        }
    }
}
