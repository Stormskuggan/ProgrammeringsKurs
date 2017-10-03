using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Shape
    {

        protected int x, y;


        public Shape()
        {
            x = 2;
            y = 1;
        }

        public Shape(int X, int Y)
        {
            x = X;
            y = Y;
        }


        public virtual string Display()
        {
            return ($"{x} , {y}");
        }

    }
}
