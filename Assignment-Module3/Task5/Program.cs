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

            int age = 0;
            int maxHeartRate = 0;
            int maxTargetHeartRate = 0;
            int minTargetHeartRate = 0;
            int newCurrentYear = 0;
            int newBirthYear = 0;
            

            Console.Write("Input first name: ");
            string newName = Console.ReadLine();
            Console.Write("Input last name: ");
            string newLastName = Console.ReadLine();
            
            try
            {

                do
                {
                    Console.Write("Input current year: ");
                    newCurrentYear = int.Parse(Console.ReadLine());
                    if (newCurrentYear < 1900)
                        Console.WriteLine("current year out of valid range!");
                } while (newCurrentYear < 1900);
                
                do
                {
                    Console.Write("Input year of birth: ");
                    newBirthYear = int.Parse(Console.ReadLine());
                    if(newBirthYear < 1900 && newBirthYear > newCurrentYear)
                        Console.WriteLine("Birthyear out of valid range!");
                } while (newBirthYear < 1900 && newBirthYear > newCurrentYear);


            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception!");
            }
            finally
            {
                HeartRates hR = new HeartRates(newName, newLastName, newBirthYear, newCurrentYear);
                newCurrentYear = 0;
                newBirthYear = 0;

                age = hR.calculateAge();
                maxHeartRate = hR.calculateMaxHeartRate(age);
                maxTargetHeartRate = hR.calculateMaxTargetHeartRate(maxHeartRate);
                minTargetHeartRate = hR.calculateMinTargetHeartRate(maxHeartRate);
                Console.WriteLine("Hi and welcome {0} {1}!", hR.FirstName, hR.LastName);
                Console.WriteLine("You are " + age + " years old, and your maximum heart rate is: " + maxHeartRate + "bpm.");
                Console.WriteLine("Your target heart rate should therefore be between " + minTargetHeartRate + " - " + maxTargetHeartRate);
            }

            


        }
         
    }
}
