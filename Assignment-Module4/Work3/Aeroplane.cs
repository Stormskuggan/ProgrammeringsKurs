﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class Aeroplane
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

        public Aeroplane()
        {

            name = "Aeroplane";
            power = 3125;
            weight = 2255;
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
