using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";

            bool continueProgram = true ;

            Console.Write("Entering 'g' exits the application, use uppercase letters! \n");
            while (continueProgram)
            {
                Console.Write("Enter your grade: ");
                inputString = Console.ReadLine();
                switch (inputString)
                {
                    case "A" :
                        Console.Write("Excellent - outstanding performance with only minor errors\n");
                        break;
                    case "B":
                        Console.Write("Very good – above the average standard but with some errors\n");
                        break;
                    case "C":
                        Console.Write("Good – generally sound work with a number of notable errors\n");
                        break;
                    case "D":
                        Console.Write("Satisfactory – fair but with significant shortcomings\n");
                        break;
                    case "E":
                        Console.Write("Sufficient – performance meets the minimum criteria\n");
                        break;
                    case "FX":
                        Console.Write("Fx Fail – some more work required before the credit can be awarded\n");
                        break;
                    case "F":
                        Console.Write("Fail - considerable further work is required\n");
                        break;
                    case "G":
                        continueProgram = false;
                        break;
                    default:
                        break;

                } 

            }

               


        }
    }
}
