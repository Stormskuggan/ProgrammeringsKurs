using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            int radius = 0;
            double volume = 0;

            Console.Write("Please input integer: ");
            radius = int.Parse(Console.ReadLine());
            for (int i = 1; i <= radius; i++)
            {
                volume = calculateVolume(i);
                Console.WriteLine("Spheres volume with radius {0} is {1}", i, volume);
            }

        }

        static double calculateVolume(int currentRadius)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(currentRadius, 3);
            return volume;
        }
    }
}
