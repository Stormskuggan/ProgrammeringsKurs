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
   
            const float growth = 1.014f;
            int year = 2017;

            float population = 6.5f;

            while (population < 10f)
            {
                population *= growth;
                year++;

            }

            Console.WriteLine("The year world population exceeds 10 billion is: {0}", year);

        }
    }
}
