using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Console.WriteLine("Shape: " + s.Display());
            Circle c = new Circle();
            Console.WriteLine("Circle: " + c.Display());
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Cylinder: " + cylinder.Display());

        }
    }
}
