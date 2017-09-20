using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class HeartRates
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        
        private int currentYear;
        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }
        private int birthYear;
        public int BirthYear
        {
            get
            {
                return birthYear;
            }

            set
            {
                birthYear = value;

            }
        }
        public HeartRates (string name1, string name2, int year1, int year2)
        {
            firstName = name1;
            lastName = name2;
            BirthYear = year1;
            CurrentYear = year2;
        }

        public int calculateAge()
        {
            return currentYear - birthYear;
        }
        public int calculateMaxHeartRate(int age)
        {
            return 220 - age;
        }

        public int calculateMaxTargetHeartRate(int maxHeartRate)
        {
            return Convert.ToInt32(maxHeartRate * 0.85);    
        }
        public int calculateMinTargetHeartRate(int maxHeartRate)
        {
            return Convert.ToInt32(maxHeartRate * 0.50);
        }
    }
}
