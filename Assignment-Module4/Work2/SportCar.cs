using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class SportCar : FourWheelVehicle 
    {


        protected double power;
        protected double acceleration;
        protected int topSpeed;

        public SportCar()
        {
            vehicleName = "Generic Sport Car";
            numberOfSeats = 2;
            power = 3500;
            weight = 800;
            acceleration = 1.18;
            topSpeed = 150;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Amount of Power: {power} \nWeight: {weight}");
            Console.WriteLine($"Top Speed: {topSpeed} \nAcceleration: {acceleration}");
           
        }
    }
}
