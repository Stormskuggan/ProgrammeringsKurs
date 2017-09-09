using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + addVariables(num1, num2));

            Console.Write("Enter a float number: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.Write("Enter a second float number: ");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + addVariables(num3, num4));

            Console.Write("Enter a first name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter a last name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("The name is " + addVariables(name1, name2));

            Console.Write("Enter the real part of the first complex number: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of the first complex number: ");
            int num6 = int.Parse(Console.ReadLine());
            Console.Write("Enter the real part of the second complex number: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of the second complex number: ");
            int num8 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + addVariables(num5, num6, num7, num8));

        }

        static int addVariables(int variable1, int variable2)
        {
            int sum = variable1 + variable2;
            return sum;
        }
        static double addVariables(double variable1, double variable2)
        {
            double sum = variable1 + variable2;
            return sum;
        }
        static string addVariables(string variable1, string variable2)
        {
            string sum = variable1 + " " + variable2;
            return sum;
        }
        static string addVariables(int variable1, int variable2, int variable3, int variable4)
        {
            string sum1 = Convert.ToString(variable1 + variable3);
            string sum2 = Convert.ToString(variable2 + variable4);

            string result = sum1 + " + i" + sum2;

            return result;
        }
    }
}
