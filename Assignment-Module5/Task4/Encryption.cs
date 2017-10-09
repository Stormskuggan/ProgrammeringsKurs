using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    static class Encryption
    {

        public static string Encode (string text)
        {
            text = text.Replace("A", "E");
            
            return text;
        }
        public static string Decode(string text)
        {


            return text;
        }


    }
}
