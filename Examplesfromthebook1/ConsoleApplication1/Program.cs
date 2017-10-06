using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream inF = File.OpenRead("test.txt");
            Stream outF = File.OpenWrite("result.txt");
            int bytesRead = 0;
            byte[] buffer = new byte[1024];
            while ((bytesRead = inF.Read(buffer, 0, 1024)) > 0)
                outF.Write(buffer, 0, bytesRead);
            inF.Close();
            outF.Close();
            string path = Directory.GetCurrentDirectory() + "\\result.txt"; DateTime dt = File.GetLastAccessTime(path); Console.WriteLine("Tha last access time: {0}", dt);
            FileInfo fi1 = new FileInfo(path);
            Console.WriteLine("Name: {0}, Length: {1}, Creation time {2}", fi1.Name, fi1.Length, fi1.CreationTime);
        }
    }
}
