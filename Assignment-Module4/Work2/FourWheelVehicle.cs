using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class FourWheelVehicle : Vehicle
    {

        protected int numberOfWheels;
        protected int numberOfSeats;

        public FourWheelVehicle()
        {
            numberOfWheels = 4;
            numberOfSeats = 4;
            vehicleName = "";
        }


        public override void Display()
        {
            Console.WriteLine("Name: " + vehicleName);
            Console.WriteLine($"Amount of wheels: {numberOfWheels} \nAmount of seats: {numberOfSeats}");
        }

    }
}
