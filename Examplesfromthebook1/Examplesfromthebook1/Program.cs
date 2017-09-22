using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examplesfromthebook1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[] { new { Name = "John", Age = 50 },
                    new { Name = "Diana", Age = 50 },
                    new { Name = "James", Age = 23 },
                    new { Name = "Francesca", Age = 21 } };
            foreach (var familyMember in names)
            {
                Console.WriteLine($"Name: {familyMember.Name}, Age: {familyMember.Age}");
            }
        }
    }
}
