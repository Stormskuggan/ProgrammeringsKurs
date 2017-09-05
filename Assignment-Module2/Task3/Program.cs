using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of square between 2-16: ");
            int inputSize = int.Parse(Console.ReadLine());
            int squareSize = checkInput(inputSize);
            displayResult(squareSize);

        }

        static int checkInput(int inputSize)
        {
            int squareSize = 0;

            if (inputSize < 2)
            {
                squareSize = 2;
                Console.WriteLine("Size too small, using the minimum of 2 instead...");

            }
            else if (inputSize > 16)
            {
                squareSize = 16;
                Console.WriteLine("Size too big, using the maximum of 16 instead...");
            }

            else
            {
                squareSize = inputSize;
            }

            return squareSize;
        }

        static void displayResult(int squareSize)

        {
            for (int i = 0; i < squareSize; i++)
            {
                for (int iA = 0; iA < squareSize; iA++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }


    }
}
