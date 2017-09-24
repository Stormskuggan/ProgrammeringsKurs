using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {

            MC motorcycle = new MC();
            Car car = new Car();
            Boat boat = new Boat();
            Aeroplane plane = new Aeroplane();


            motorcycle.Display();
            car.Display();
            boat.Display();
            plane.Display();


        }
    }
}
