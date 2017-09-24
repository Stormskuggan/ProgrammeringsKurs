using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWork1
{
    class Program
    {

        static void Main(string[] args)
        {

            
            int[] studentGrades = new int[10];
            Random r = new Random();
            string histogram = "";
            int studentNumber = 1;

            for (int i = 0; i < 10; i++)
            {
                studentGrades[i] = r.Next(1,10);
            }

            foreach(int grade in studentGrades)
            {
                
                for (int i = 0; i < grade; i++)
                {
                    histogram += "*";
                }

                Console.WriteLine($"Student {studentNumber} has got {grade} : " + histogram);
                studentNumber++;
                histogram = "";
            }

            
        }
    }
}
