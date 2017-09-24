using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    interface IPower
    {
        
        string Name
        {
            get;
        }
        double SpecificPower();

        void Display();

        

    }
}
