using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fileName + ".txt", true);
            sw.Write(text);
            sw.Close();


            Console.ReadLine();
        }
    }
}
