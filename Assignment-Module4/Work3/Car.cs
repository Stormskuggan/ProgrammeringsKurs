using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class Car : IPower
    {


        private double power;
        private double weight;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Car()
        {

            name = "Car";
            power = 1500;
            weight = 1250;
        }




        public double SpecificPower()
        {
            return power / weight;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name} \nSpecific Power: {SpecificPower()}\n");
        }

    }
}
