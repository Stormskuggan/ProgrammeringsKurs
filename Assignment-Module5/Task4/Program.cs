using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {


            //StringBuilder str = new StringBuilder(Console.ReadLine());
            //Console.WriteLine("The wrong written text is \n{0}", str.ToString());
            //str.Replace("e", "a");
            //Console.WriteLine("The correct text is \n{0}", str.ToString());

            int key = 9;
            char ch = Convert.ToChar(Console.ReadLine());

            char d = char.IsUpper(ch) ? 'A' : 'a';


            //ch = (char)((((ch + key) - d) % 26) + d);

            //Console.WriteLine((char)((((ch + key) - d) % 26) + d));
            Console.WriteLine((char) (ch + key));
        }
    }
}
