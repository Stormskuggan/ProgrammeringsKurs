using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Circle : Shape
    {

        private double radius;
        private double area;


        public Circle() : base()
        {
            radius = 5;
            area = calculateArea(radius);

        }



        public double calculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }


        public override string Display()
        {
            return ($"{x} , {y}, {area}");
        }
    }
}
