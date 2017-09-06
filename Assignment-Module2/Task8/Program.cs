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


            addTwoVariables();
        }

        static int addTwoVariables(int variable1, int variable2)
        {
            int sum = variable1 + variable2;
            return sum;
        }
        static float addTwoVariables(float variable1, float variable2)
        {
            float sum = variable1 + variable2;
            return sum;
        }

    }
}
