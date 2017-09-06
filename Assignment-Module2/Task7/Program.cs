using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowestNumber;
            int inputNumber;
            bool keepIterating = true;

            Console.Write("This app calculates the smallest number input. To stop number collecting enter the number 0.\ninput number: ");
            lowestNumber = int.Parse(Console.ReadLine());
            if (lowestNumber == 0)
            {
                keepIterating = false;
            }
               

            while (keepIterating)
            {
                Console.Write("input number: ");
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < lowestNumber && inputNumber > 0)
                {
                    lowestNumber = inputNumber;
                }
                if (inputNumber == 0)
                {
                    keepIterating = false;
                }

            }

            Console.WriteLine("The lowest number was {0}",lowestNumber);

        }
    }
}
