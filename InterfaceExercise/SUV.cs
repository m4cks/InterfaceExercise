using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
    internal class SUV : IVehicle, ICompany
    {
        public int cargoHoldSize;
        public int numSeats;


        public int wheels { get; set; }
        public string name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
