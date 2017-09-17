using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Sphere mySphere = new Sphere(9);

            Console.WriteLine("Radius is currently: " + mySphere.SphereRadius);
            Console.Write("Input a new radius for this sphere: ");
            try
            {
                mySphere.SphereRadius = int.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("input must be numeric. Program will continue");
            }
            Console.WriteLine("Volume of sphere is: " + mySphere.CalculateSphereVolume());
          
        }
            
        
    }
    

    
}
