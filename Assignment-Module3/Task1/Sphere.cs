using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Sphere
    {
        private int sphereRadius;

        public int SphereRadius
        {
            get
            {
                return sphereRadius;
            }
            set
            {
                sphereRadius = value;
            }
        }
        //Constructor
        public Sphere()
        {

        }
        //Constructor
        public Sphere(int radius)
        {
            SphereRadius = radius;
        }

        public double CalculateSphereVolume()
        {
            double sphereVolume = 4 / 3 * Math.PI * Math.Pow(sphereRadius, 3);
            return sphereVolume;
        }



    }
}
