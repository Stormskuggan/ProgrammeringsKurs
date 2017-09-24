using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class Boat
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

        public Boat()
        {

            name = "Boat";
            power = 2500;
            weight = 2000;
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
