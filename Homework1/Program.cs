using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();

        }

        public static void Task1()
        {
            Console.WriteLine("Please enter the first string: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the second string: ");
            string familyName = Console.ReadLine();
            Console.WriteLine("The result is: {0} {1}", firstName, familyName);

        }
        public static void Task2()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int oddOrEven = inputNumber % 2;
            if (oddOrEven == 0)
                Console.WriteLine("Even");
            if (oddOrEven == 1)
                Console.WriteLine("Odd");
        }
        public static void Task3()
        {

            Console.WriteLine("Please enter the first Number: ");
            float firstNr = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second Number: ");
            float secondNr = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third Number: ");
            float thirdNr = float.Parse(Console.ReadLine());
            Console.WriteLine("{0}\t{1}\t{2}",firstNr, secondNr, thirdNr);

        }
        public static void Task4()
        {
            Console.Write("JJJJJJ\n     J\n     J\nJ    J\n JJJJ \n\n");
            Console.Write(" SSSS\nS\n SSSS\n     S\n SSSS\n \n");
        }
        public static void Task5()
        {
            Console.WriteLine("Please enter the xValue: ");
            float xValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the yValue: ");
            float yValue = float.Parse(Console.ReadLine());
            Console.WriteLine("The sum of xValue with yValue is: {0}", xValue + yValue);
            Console.WriteLine("The difference between xValue with yValue is: {0}", xValue - yValue);
            Console.WriteLine("xValue multiplied by yValue is: {0}", xValue * yValue);
            Console.WriteLine("xValue divided by yValue is: {0}", xValue / yValue);
            Console.WriteLine("Remainder of the division of xValue by yValue is: {0}", xValue % yValue);

        }
        public static void Task6()
        {
            const Double pi = Math.PI;

            Console.WriteLine("Please enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("The Diameter is {0}", 2 * radius);
            Console.WriteLine("The circumference is {0}",2 * radius * pi);
            Console.WriteLine("The area is {0}", Math.Pow(radius, 2) * pi);
        }
        public static void Task7()
        {
            int Value = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", Value / 1000, Value / 100 % 10, (Value % 100) / 10, Value % 10);
        }
        public static void Task8()
        {
            int Value = int.Parse(Console.ReadLine());
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("{0}\t{1}\t{2}", Value, Math.Pow(Value, 2), Math.Pow(Value, 3));
        }

    }

}
