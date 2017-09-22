using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Cylinder : Shape
    {
        private double radius;
        private double height;
        private double area;
        private double volume;


        public Cylinder() : base()
        {
            radius = 5;
            height = 10;
            area = calculateArea(radius, height);
            volume = calculateVolume(radius, height);
        }



        public double calculateArea(double r, double h)
        {
            return (2 * Math.PI * Math.Pow(r, 2)) + (2 * Math.PI * radius* h);
        }

        public double calculateVolume(double radius, double h)
        {
            return Math.PI * Math.Pow(radius, 2)* height;
        }

        public override string Display()
        {
            return ($"{x} , {y}, {area}, {volume}");
        }
    }
}
