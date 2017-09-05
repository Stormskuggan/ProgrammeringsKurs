using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            int celsius = -30;
            double fahrenheit;

            Console.WriteLine("Celsius\tFarenheit");

            while(celsius <= 50)
            {
                fahrenheit = (9 / 5) * celsius + 32;
                Console.WriteLine("{0}\t{1}", celsius, fahrenheit);
                celsius += 5;
            }

        }
    }
}
