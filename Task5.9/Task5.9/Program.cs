using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 50 divisible by 3 but not divisible by 5 are following:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
