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

            int number = 1;

            Console.WriteLine("Number\tSquare\tCube");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", number, Math.Pow(number, 2), Math.Pow(number, 3));
                number++;
            }
        }
    }
}
