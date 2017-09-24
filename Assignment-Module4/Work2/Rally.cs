using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    class Rally : SportCar
    {

        
        public Rally()
        {


            vehicleName = "Rally Car";
            numberOfSeats = 1;
            power = 5000;
            weight = 1000;
            acceleration = 1.25;
            topSpeed = 180;
            
        }


        public double specificPower()
        {
            return power / weight;
        }

        public override void Display()
        {

            base.Display();

            Console.WriteLine($"Specific Power: {specificPower()}");
        }
    }
}
