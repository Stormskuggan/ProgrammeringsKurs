using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Bicycle
    {
        private static int objectCount = 0;

        private int id;
        public int Id
        {
            get
            {
                return id;
            }

        }
        private int bicycleSpeed;
        public int BicycleSpeed
        {
            get
            {
                return bicycleSpeed;
            }
            set
            {
                bicycleSpeed = value;
            }
        }

        //constructor
        public Bicycle()
        {
            bicycleSpeed = 0;
            objectCount++;
            id = objectCount;
        }

        public void Accelerate()
        {
            bicycleSpeed += 5;
        }
        public void Brake()
        {
            bicycleSpeed -= 5;
        }

    }
}
