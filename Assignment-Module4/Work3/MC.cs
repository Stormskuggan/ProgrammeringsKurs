using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class MC : IPower
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

        public MC()
        {

            name = "Motor Cycle";
            power = 1000;
            weight = 600;
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
