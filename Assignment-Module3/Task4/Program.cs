using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycleA = new Bicycle();
            Bicycle bicycleB = new Bicycle();
            Bicycle bicycleC = new Bicycle();
            Bicycle bicycleD = new Bicycle();
            Bicycle bicycleE = new Bicycle();

            for (int i = 0; i < 1; i++)
            {
                bicycleA.Accelerate();
            }
            for (int i = 0; i < 2; i++)
            {
                bicycleB.Accelerate();
            }
            for (int i = 0; i < 3; i++)
            {
                bicycleC.Accelerate();
            }
            for (int i = 0; i < 4; i++)
            {
                bicycleD.Accelerate();
            }
            for (int i = 0; i < 6; i++)
            {
                bicycleE.Accelerate();
            }

            printBicycle(bicycleA);
            printBicycle(bicycleB);
            printBicycle(bicycleC);
            printBicycle(bicycleD);
            printBicycle(bicycleE);

        }

        public static void printBicycle(Bicycle bicycle)
        {

            Console.WriteLine("Bicycle Id: " + bicycle.Id);
            Console.WriteLine("Current speed: " + bicycle.BicycleSpeed + " km/h");
        }



    }
}
